using System.Drawing;
using System.Windows.Forms;

namespace GameUI
{
    public partial class FormGame : Form
    {
        private const int k_MarginBorders = 12;
        private const int k_SquareCardSize = 85;
        private readonly Color r_FirstPlayerColor = Color.LightBlue;
        private readonly Color r_SecondPlayerColor = Color.LightGreen;

        private readonly int r_Rows;
        private readonly int r_Columns;
        private GameSlot[,] m_SlotButtons;

        public FormGame(int i_Rows, int i_Columns)
        {
            r_Rows = i_Rows;
            r_Columns = i_Columns;
            initializeGameSlots();
            InitializeComponent();
        }

        internal void gameRestart()
        {
            initializeGameSlots();
            InitializeComponent();
        }

        public Button[,] SlotButtons
        {
            get 
            { 
                return m_SlotButtons;
            }
        }

        public Label CurrentPlayer
        {
            get 
            { 
                return labelCurrentPlayer; 
            }
        }

        public Label FirstPlayerScore
        {
            get
            {
                return labelFirstPlayerScore;
            }
        }

        public Label SecondPlayerScore
        {
            get
            {
                return labelSecondPlayerScore;
            }
        }

        private void initializeGameSlots()
        {
            m_SlotButtons = new GameSlot[r_Rows, r_Columns];

            for (int i = 0; i < r_Rows; i++)
            {
                for (int j = 0; j < r_Columns; j++)
                {
                    m_SlotButtons[i, j] = new GameSlot(i, j)
                    {
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Size = new Size(k_SquareCardSize, k_SquareCardSize),
                        Left = (i * (k_SquareCardSize + k_MarginBorders)) + k_MarginBorders,
                        Top = (j * (k_SquareCardSize + k_MarginBorders)) + k_MarginBorders
                    };

                    Controls.Add(m_SlotButtons[i, j]);
                }
            }
        }
    }
}
