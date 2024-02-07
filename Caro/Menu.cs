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
        private BuildChecssBoard buildChecssBoard;
        private Panel panelChessBoard;

        public Panel PanelChessBoard { get => panelChessBoard; set => panelChessBoard = value; }
        public BuildChecssBoard BuildChecssBoard { get => buildChecssBoard; set => buildChecssBoard = value; }

        public Menu(BuildChecssBoard buildChecssBoard, Panel Panel) 
        {
            PanelChessBoard = Panel;
            BuildChecssBoard = buildChecssBoard;
        }
       
        public void New_Game()
        {
            PanelChessBoard.Controls.Clear();
            BuildChecssBoard.DrawChessboard();
        }

        public void Undo()
        {
            if (BuildChecssBoard.ListRowed.Count > 0 && BuildChecssBoard.ListColed.Count > 0)
            {
                int lastRow = BuildChecssBoard.ListRowed.Pop();
                int lastCol = BuildChecssBoard.ListColed.Pop();
                BuildChecssBoard.Matrix[lastRow][lastCol].BackgroundImage = null;

                if (buildChecssBoard.check_X)
                {
                    buildChecssBoard.check_X = false;
                    buildChecssBoard.check_O = true;
                }
                else
                {
                    buildChecssBoard.check_X = true;
                    buildChecssBoard.check_O = false;
                }
            }
        }
    }
}
