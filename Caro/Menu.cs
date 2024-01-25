using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Caro
{
    internal class Menu
    {
        public static void New_Game(BuildChecssBoard buildChecssBoard, Panel PanelChessBoard)
        {
            PanelChessBoard.Controls.Clear();
            buildChecssBoard.DrawChessboard(PanelChessBoard);
        }
        public static void Undo(List<List<Button>> Matrix, Stack<int> row, Stack<int> col)
        {
            if (row.Count > 0 && col.Count > 0)
            {
                int lastRow = row.Pop();
                int lastCol = col.Pop();
                Matrix[lastRow][lastCol].BackgroundImage = null;
            }
        }
    }
}
