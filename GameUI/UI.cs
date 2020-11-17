using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using GameLogic;

namespace GameUI
{
    public class UI
    {
        private readonly FormSettings r_SettingsForm;
        private FormGame m_GameForm;
        private GameManager m_GameManager;
        private Dictionary<char, Image> m_ImagesCollection;
        private GameSlot m_FirstChoise;
        private bool m_IsFirstPlayerTurn;
        private bool m_IsFirstChoise;

        public UI()
        {
            r_SettingsForm = new FormSettings();
            r_SettingsForm.ButtonStart.Click += StartButton_Click;
            m_IsFirstPlayerTurn = true;
            m_IsFirstChoise = true;
        }

        public void Run()
        {
            r_SettingsForm.ShowDialog();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            m_GameManager = new GameManager(r_SettingsForm.FirstPlayerName, r_SettingsForm.SecondPlayerName, r_SettingsForm.SecondPlayerIsReal, r_SettingsForm.BoardRows, r_SettingsForm.BoardColumns, r_SettingsForm.Difficulty);
            m_GameForm = new FormGame(r_SettingsForm.BoardRows, r_SettingsForm.BoardColumns);
            r_SettingsForm.Hide();
            updateCurrentPlayerLabel();
            updatePlayersInfoLabels();
            initializeImagesCollection();
            initializeFormButtons();
            m_GameForm.ShowDialog();
        }

        private void initializeFormButtons()
        {
            for (int i = 0; i < m_GameManager.m_GameBoard.Rows; i++)
            {
                for (int j = 0; j < m_GameManager.m_GameBoard.Columns; j++)
                {
                    m_GameForm.SlotButtons[i, j].Click += SlotButton_Click;
                }
            }
        }

        private void updatePlayersInfoLabels()
        {
            m_GameForm.FirstPlayerScore.Text = string.Format("{0}: {1} Pairs", m_GameManager.FirstPlayer.Name, m_GameManager.FirstPlayer.Score);
            m_GameForm.SecondPlayerScore.Text = string.Format("{0}: {1} Pairs", m_GameManager.SecondPlayer.Name, m_GameManager.SecondPlayer.Score);
            m_GameForm.FirstPlayerScore.Update();
            m_GameForm.SecondPlayerScore.Update();
        }

        private void updateCurrentPlayerLabel()
        {
            Player currentPlayer = m_IsFirstPlayerTurn ? m_GameManager.FirstPlayer : m_GameManager.SecondPlayer;
            m_GameForm.CurrentPlayer.Text = string.Format("Current Player: {0}", currentPlayer.Name);
            m_GameForm.CurrentPlayer.BackColor = m_IsFirstPlayerTurn ? m_GameForm.FirstPlayerScore.BackColor : m_GameForm.SecondPlayerScore.BackColor;
            m_GameForm.CurrentPlayer.Update();
        }

        private void SlotButton_Click(object sender, EventArgs e)
        {
            playChoise(sender as GameSlot);
        }

        private void playChoise(GameSlot i_SlotClicked)
        {
            GameLogic.Point pointChosen = i_SlotClicked.SlotPoint;
            exposeSlot(pointChosen);

            if (m_IsFirstChoise)
            {
                m_GameManager.PlayChoise(pointChosen);
                m_FirstChoise = i_SlotClicked;
                m_IsFirstChoise = false;
            }
            else
            {
                System.Threading.Thread.Sleep(1000);

                if (m_GameManager.PlayChoise(m_IsFirstPlayerTurn, m_FirstChoise.SlotPoint, pointChosen))
                {
                    updatePlayersInfoLabels();

                    if (m_GameManager.IsGameOver())
                    {
                        gameOverDialog();
                    }
                }
                else
                {
                    m_GameManager.m_GameBoard.FlipSlot(pointChosen);
                    m_GameManager.m_GameBoard.FlipSlot(m_FirstChoise.SlotPoint);
                    hideSlot(pointChosen);
                    hideSlot(m_FirstChoise.SlotPoint);
                    m_IsFirstPlayerTurn = !m_IsFirstPlayerTurn;
                    updateCurrentPlayerLabel();

                    if (!m_GameManager.IsSecondPlayerReal())
                    {
                        computerTurn();
                    }
                }

                m_IsFirstChoise = true;
            }
        }

        private void computerTurn()
        {
            System.Threading.Thread.Sleep(1000);
            GameLogic.Point firstChoise = m_GameManager.ComputerRandomChoise();
            m_GameManager.PlayChoise(firstChoise);
            exposeSlot(firstChoise);
            
            System.Threading.Thread.Sleep(1000);
            GameLogic.Point secondChoise = m_GameManager.ComputerRandomChoise(firstChoise);
            exposeSlot(secondChoise);

            if (m_GameManager.PlayChoise(m_IsFirstPlayerTurn, firstChoise, secondChoise))
            {
                updatePlayersInfoLabels();

                if (m_GameManager.IsGameOver())
                {
                    gameOverDialog();
                }
                else
                {
                    computerTurn();
                }
            }
            else
            {
                System.Threading.Thread.Sleep(1000);
                m_IsFirstPlayerTurn = !m_IsFirstPlayerTurn;
                updateCurrentPlayerLabel();
                m_GameManager.m_GameBoard.FlipSlot(firstChoise);
                m_GameManager.m_GameBoard.FlipSlot(secondChoise);
                hideSlot(firstChoise);
                hideSlot(secondChoise);
            }
        }

        private void exposeSlot(GameLogic.Point i_Point)
        {
            Color backColorCurrentPlayer = m_IsFirstPlayerTurn ? m_GameForm.FirstPlayerScore.BackColor : m_GameForm.SecondPlayerScore.BackColor;
            int rowIndex = i_Point.RowIndex;
            int colIndex = i_Point.ColumnIndex;
            Image slotImage;
            m_ImagesCollection.TryGetValue(m_GameManager.m_GameBoard.SlotBoard[rowIndex, colIndex].Letter, out slotImage);

            m_GameForm.SlotButtons[rowIndex, colIndex].Enabled = false;
            m_GameForm.SlotButtons[rowIndex, colIndex].BackgroundImage = slotImage;
            m_GameForm.SlotButtons[rowIndex, colIndex].FlatStyle = FlatStyle.Flat;
            m_GameForm.SlotButtons[rowIndex, colIndex].FlatAppearance.BorderColor = backColorCurrentPlayer;
            m_GameForm.SlotButtons[rowIndex, colIndex].FlatAppearance.BorderSize = 3;
            m_GameForm.SlotButtons[rowIndex, colIndex].Update();
        }

        private void hideSlot(GameLogic.Point i_Point)
        {
            int rowIndex = i_Point.RowIndex;
            int colIndex = i_Point.ColumnIndex;

            m_GameForm.SlotButtons[rowIndex, colIndex].Enabled = true;
            m_GameForm.SlotButtons[rowIndex, colIndex].BackgroundImage = null;
            m_GameForm.SlotButtons[rowIndex, colIndex].FlatStyle = FlatStyle.System;
            m_GameForm.SlotButtons[rowIndex, colIndex].Update();
        }

        private void gameOverDialog()
        {
            int firstPlayerScore = m_GameManager.FirstPlayer.Score;
            int secondPlayerScore = m_GameManager.SecondPlayer.Score;
            string endGameMsg;

            if (firstPlayerScore != secondPlayerScore)
            {
                endGameMsg = string.Format("Game over.{1}{0} won the game!{1}", (firstPlayerScore > secondPlayerScore) ? m_GameManager.FirstPlayer.Name : m_GameManager.SecondPlayer.Name, Environment.NewLine);
            }
            else
            {
                endGameMsg = string.Format("Game over.{0}It's a TIE!{0}", Environment.NewLine);
            }

            DialogResult gameOverDialog = MessageBox.Show(string.Format("{0}{1}Do you want a rematch?", endGameMsg, Environment.NewLine), "Memory Game Result", MessageBoxButtons.YesNo);
            
            if (gameOverDialog == DialogResult.Yes)
            {
                restartGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void restartGame()
        {
            m_GameManager = new GameManager(r_SettingsForm.FirstPlayerName, r_SettingsForm.SecondPlayerName, r_SettingsForm.SecondPlayerIsReal, r_SettingsForm.BoardRows, r_SettingsForm.BoardColumns, r_SettingsForm.Difficulty);
            m_GameForm.Controls.Clear();
            m_GameForm.gameRestart();
            m_IsFirstPlayerTurn = true;
            m_IsFirstChoise = true;
            initializeFormButtons();
            initializeImagesCollection();
            updateCurrentPlayerLabel();
            updatePlayersInfoLabels();
        }

        private void initializeImagesCollection()
        {
            m_ImagesCollection = new Dictionary<char, Image>();
            int numOfPairs = m_GameManager.m_GameBoard.NumOfPairs;
            WebClient wClient = new WebClient();

            for (int i = 0; i < numOfPairs; i++)
            {
                Image newImage = Image.FromStream(new MemoryStream(wClient.DownloadData("https://picsum.photos/80")));
                m_ImagesCollection.Add((char)('A' + i), newImage);
            }
        }
    }
}
