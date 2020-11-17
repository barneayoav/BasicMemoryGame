using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameUI
{
    public enum eBoardSize
    {
        FourFour,
        FourFive,
        FourSix,
        FiveFour,
        FiveSix,
        SixFour,
        SixFive,
        SixSix
    }

    public enum eDifficulty
    {
        Easy = 8,
        Medium = 5,
        Hard = 3
    }

    public partial class FormSettings : Form
    {
        private const int k_DefaultBoardRows = 4;
        private const int k_DefaultBoardColumns = 4;
        private const string k_AgainstAFriendStr = "Against a Friend";
        private const string k_AgainstComputerStr = "Against Computer";
        private const string k_ComputerName = "- computer -";

        private int m_BoardRows;
        private int m_BoardColumns;
        private eBoardSize m_BoardSize;
        private eDifficulty m_ComputerDifficulty;

        public FormSettings()
        {
            m_BoardSize = eBoardSize.FourFour;
            m_ComputerDifficulty = eDifficulty.Easy;
            m_BoardRows = k_DefaultBoardRows;
            m_BoardColumns = k_DefaultBoardColumns;
            InitializeComponent();
            textBoxSecondPlayer.Text = k_ComputerName;
        }

        public Button ButtonStart
        {
            get { return this.buttonStart; }
        }

        public Button BottonFormSize
        {
            get { return this.buttonBoardSize; }
        }

        public string FirstPlayerName
        {
            get { return textBoxFirstPlayer.Text; }
        }

        public string SecondPlayerName
        {
            get { return textBoxSecondPlayer.Text; }
        }

        public bool SecondPlayerIsReal 
        { 
            get { return this.textBoxSecondPlayer.Enabled; }
        }

        public int BoardColumns
        {
            get { return this.m_BoardColumns; }
        }

        public int BoardRows
        {
            get { return this.m_BoardRows; }
        }

        public int Difficulty
        {
            get { return (int)this.m_ComputerDifficulty; }
        }

        private void buttonAgainstPlayer_Click_1(object sender, EventArgs e)
        {
            textBoxSecondPlayer.Text = string.Empty;
            textBoxSecondPlayer.BackColor = Color.White;
            textBoxSecondPlayer.Enabled = true;
            buttonAgainstFriend.Text = k_AgainstComputerStr;
            buttonAgainstFriend.Click -= buttonAgainstPlayer_Click_1;
            buttonAgainstFriend.Click += new EventHandler(buttonAgainstPlayer_Click_2);
            buttonComputerDifficulty.Visible = false;
            labelDifficulty.Visible = false;
        }

        private void buttonAgainstPlayer_Click_2(object sender, EventArgs e)
        {
            textBoxSecondPlayer.Text = k_ComputerName;
            textBoxSecondPlayer.BackColor = Color.LightGray;
            textBoxSecondPlayer.Enabled = false;
            buttonAgainstFriend.Text = k_AgainstAFriendStr;
            buttonAgainstFriend.Click -= buttonAgainstPlayer_Click_2;
            buttonAgainstFriend.Click += new EventHandler(buttonAgainstPlayer_Click_1);
            buttonComputerDifficulty.Visible = true;
            labelDifficulty.Visible = true;
        }

        private void buttonBoardSize_Click(object sender, EventArgs e)
        {
            switch (m_BoardSize)
            {
                case eBoardSize.FourFour:
                    buttonBoardSize.Text = "4 x 5";
                    m_BoardSize = eBoardSize.FourFive;
                    m_BoardRows = 4;
                    m_BoardColumns = 5;
                    break;

                case eBoardSize.FourFive:
                    buttonBoardSize.Text = "4 x 6";
                    m_BoardSize = eBoardSize.FourSix;
                    m_BoardRows = 4;
                    m_BoardColumns = 6;
                    break;

                case eBoardSize.FourSix:
                    buttonBoardSize.Text = "5 x 4";
                    m_BoardSize = eBoardSize.FiveFour;
                    m_BoardRows = 5;
                    m_BoardColumns = 4;
                    break;

                case eBoardSize.FiveFour:
                    buttonBoardSize.Text = "5 x 6";
                    m_BoardSize = eBoardSize.FiveSix;
                    m_BoardRows = 5;
                    m_BoardColumns = 6;
                    break;

                case eBoardSize.FiveSix:
                    buttonBoardSize.Text = "6 x 4";
                    m_BoardSize = eBoardSize.SixFour;
                    m_BoardRows = 6;
                    m_BoardColumns = 4;
                    break;

                case eBoardSize.SixFour:
                    buttonBoardSize.Text = "6 x 5";
                    m_BoardSize = eBoardSize.SixFive;
                    m_BoardRows = 6;
                    m_BoardColumns = 5;
                    break;

                case eBoardSize.SixFive:
                    buttonBoardSize.Text = "6 x 6";
                    m_BoardSize = eBoardSize.SixSix;
                    m_BoardRows = 6;
                    m_BoardColumns = 6;
                    break;

                case eBoardSize.SixSix:
                default:
                    buttonBoardSize.Text = "4 x 4";
                    m_BoardSize = eBoardSize.FourFour;
                    m_BoardRows = 4;
                    m_BoardColumns = 4;
                    break;
            }
        }

        private void buttonComputerDifficulty_Click(object sender, EventArgs e)
        {
            switch (m_ComputerDifficulty)
            {
                case eDifficulty.Easy:
                    buttonComputerDifficulty.Text = "Medium";
                    m_ComputerDifficulty = eDifficulty.Medium;
                    break;

                case eDifficulty.Medium:
                    buttonComputerDifficulty.Text = "Hard";
                    m_ComputerDifficulty = eDifficulty.Hard;
                    break;

                case eDifficulty.Hard:
                default:
                    buttonComputerDifficulty.Text = "Easy";
                    m_ComputerDifficulty = eDifficulty.Easy;
                    break;
            }
        }
    }
}
