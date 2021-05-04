using System;
using System.Collections.Generic;

namespace GameLogic
{
    public class GameManager
    {
        private readonly Random m_RandomIndex;
        private readonly List<Point> m_AvailableSlots;

        public Board m_GameBoard;
        private Player m_FirstPlayer;
        private Player m_SecondPlayer;
        private int m_ComputerDifficulty;

        public GameManager(string i_FirstPlayerName, string i_SecondPlayerName, bool i_GameOption, int i_Rows, int i_Columns, int i_ComputerDifficulty)
        {
            m_FirstPlayer = new Player(i_FirstPlayerName, true);
            m_SecondPlayer = new Player(i_SecondPlayerName, i_GameOption);
            m_GameBoard = new Board(i_Rows, i_Columns);
            m_RandomIndex = new Random();
            m_AvailableSlots = new List<Point>();
            m_ComputerDifficulty = i_ComputerDifficulty;
            initializeList();
        }

        private void initializeList()
        {
            for (int i = 0; i < m_GameBoard.Rows; i++)
            {
                for (int j = 0; j < m_GameBoard.Columns; j++)
                {
                    m_AvailableSlots.Add(new Point(i, j));
                }
            }
        }

        public void PlayChoise(Point i_FirstChoise)
        {
            m_GameBoard.FlipSlot(i_FirstChoise);
        }

        public bool PlayChoise(bool i_FirstPlayerTurn, Point i_FirstChoise, Point i_SecondChoise)
        {
            bool isMatch;

            m_GameBoard.FlipSlot(i_SecondChoise);

            if (isMatch = m_GameBoard.IsMatch(i_FirstChoise, i_SecondChoise))
            {
                m_AvailableSlots.Remove(i_FirstChoise);
                m_AvailableSlots.Remove(i_SecondChoise);
                if (i_FirstPlayerTurn)
                {
                    m_FirstPlayer.AddPoint();
                }
                else
                {
                    m_SecondPlayer.AddPoint();
                }
            }

            return isMatch;
        }

        public Point ComputerRandomChoise()
        {
            return m_AvailableSlots[m_RandomIndex.Next(0, m_AvailableSlots.Count)];
        }

        public Point ComputerRandomChoise(Point i_FirstChoise)
        {
            m_AvailableSlots.Remove(i_FirstChoise);
            Point secondPoint = i_FirstChoise; // Just to avoid error with Null
            double isSmartMove = m_RandomIndex.Next(1, m_ComputerDifficulty + 1);

            if (isSmartMove == 1)
            {
                foreach (Point point in m_AvailableSlots)
                {
                    if (m_GameBoard.IsMatch(i_FirstChoise, point))
                    {
                        secondPoint = point;
                        break;
                    }
                }
            }
            else
            {
                secondPoint = m_AvailableSlots[m_RandomIndex.Next(0, m_AvailableSlots.Count)];
            }

            m_AvailableSlots.Add(i_FirstChoise);

            return secondPoint;
        }

        public Player FirstPlayer
        {
            get
            {
                return this.m_FirstPlayer;
            }
        }

        public Player SecondPlayer
        {
            get
            {
                return this.m_SecondPlayer;
            }
        }

        public bool IsSecondPlayerReal()
        {
            return m_SecondPlayer.IsRealPlayer();
        }

        public bool IsLegalTurn(int i_RowIndex, int i_ColumnIndex)
        {
            return !m_GameBoard.m_Board[i_RowIndex, i_ColumnIndex].Revealed;
        }

        public bool IsGameOver()
        {
            int totalGainedScore = m_FirstPlayer.Score + m_SecondPlayer.Score;

            return totalGainedScore == m_GameBoard.NumOfPairs;
        }
    }

    public struct Player
    {
        private readonly string m_PlayerName;
        private readonly bool m_RealPlayer;
        private int m_PlayerScore;

        public Player(string i_PlayerName, bool i_IsRealPlayer)
        {
            m_PlayerName = i_PlayerName;
            m_PlayerScore = 0;
            m_RealPlayer = i_IsRealPlayer;
        }

        public string Name
        {
            get
            {
                return m_PlayerName;
            }
        }

        public int Score
        {
            get
            {
                return m_PlayerScore;
            }
        }

        public bool IsRealPlayer()
        {
            return m_RealPlayer;
        }

        public void AddPoint()
        {
            m_PlayerScore++;
        }
    }
}
