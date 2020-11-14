using System;
using System.Collections.Generic;

namespace GameLogic
{
    public class Board
    {
        public Slot[,] m_Board;
        private readonly int m_Rows;
        private readonly int m_Columns;
        private readonly int m_NumOfPairs;

        public Board(int i_Rows, int i_Columns)
        {
            m_Board = new Slot[i_Rows, i_Columns];
            m_Rows = i_Rows;
            m_Columns = i_Columns;
            m_NumOfPairs = m_Rows * m_Columns / 2;
            initializeBoard();
        }

        public Slot[,] SlotBoard
        {
            get 
            { 
                return m_Board;
            }
        }

        public int Rows
        {
            get
            {
                return m_Rows;
            }
        }

        public int Columns
        {
            get
            {
                return m_Columns;
            }
        }

        public int NumOfPairs
        {
            get
            {
                return m_NumOfPairs;
            }
        }

        private void initializeBoard()
        {
            List<char> lettersToFill = new List<char>();
            Random randomGenerator = new Random();

            for (int i = 0; i < m_Rows * m_Columns / 2; i++)
            {
                lettersToFill.Add((char)('A' + i));
                lettersToFill.Add((char)('A' + i));
            }

            for (int i = 0; i < m_Rows; i++)
            {
                for (int j = 0; j < m_Columns; j++)
                {
                    int randomIndex = randomGenerator.Next(0, lettersToFill.Count);
                    m_Board[i, j] = new Slot(lettersToFill[randomIndex]);
                    lettersToFill.RemoveAt(randomIndex);
                }
            }
        }

        public bool IsMatch(Point i_FirstChoise, Point i_SecondChoise)
        {
            return m_Board[i_FirstChoise.RowIndex, i_FirstChoise.ColumnIndex].IsPair(m_Board[i_SecondChoise.RowIndex, i_SecondChoise.ColumnIndex]);
        }

        public void FlipSlot(Point i_CurrentChoise)
        {
            m_Board[i_CurrentChoise.RowIndex, i_CurrentChoise.ColumnIndex].Revealed ^= true;
        }
    }

    public struct Slot
    {
        private readonly char m_Letter;
        private bool m_Revealed;

        public Slot(char i_Letter)
        {
            m_Letter = i_Letter;
            m_Revealed = false;
        }

        public char Letter
        {
            get
            {
                return m_Letter;
            }
        }

        public bool Revealed
        {
            get
            {
                return m_Revealed;
            }

            set
            {
                m_Revealed = value;
            }
        }

        public bool IsPair(Slot i_OtherSlot)
        {
            return Letter.Equals(i_OtherSlot.Letter);
        }
    }

    public struct Point
    {
        private readonly int m_RowIndex;
        private readonly int m_ColumnIndex;

        public Point(int i_RowIndex, int i_ColumnIndex)
        {
            m_RowIndex = i_RowIndex;
            m_ColumnIndex = i_ColumnIndex;
        }

        public int RowIndex
        {
            get
            {
                return m_RowIndex;
            }
        }

        public int ColumnIndex
        {
            get
            {
                return m_ColumnIndex;
            }
        }
    }
}
