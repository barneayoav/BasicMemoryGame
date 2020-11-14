using System.Windows.Forms;

namespace GameUI 
{
    internal class GameSlot : Button
    {
        private readonly GameLogic.Point r_Point;

        public GameSlot(int i_RowIndex, int i_ColumnIndex)
        {
            r_Point = new GameLogic.Point(i_RowIndex, i_ColumnIndex);
        }

        public GameLogic.Point SlotPoint
        {
            get
            {
                return r_Point;
            }
        }
    }
}