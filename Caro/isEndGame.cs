using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Caro
{
    internal class isEndGame
    {
        int[] ArrA = { -1, 1, 0, 0, -1, 1, -1, 1 };
        int[] ArrB = { 0, 0, -1, 1, -1, 1, 1, -1 };
        List<List<Button>> matrix = new List<List<Button>>();

        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        public isEndGame(List<List<Button>> mat)
        {
            Matrix = mat;
        }

        public bool check_win(Button btn)
        {
            Index indexObj = new Index(Matrix);
            Index index = indexObj.GetIndex(btn);
            int m = index.X, n = index.Y;
            if ((Count(0, m, n) + Count(1, m, n)) >= 4 || (Count(2, m, n) + Count(3, m, n)) >= 4 || 
                (Count(4, m, n) + Count(5, m, n)) >= 4 || (Count(6, m, n) + Count(7, m, n)) >= 4)
                return true;
            return false;
        }

        public int Count(int col, int m, int n)
        {
            int count = 0;
            string temp = Matrix[m][n].Text;
            m += ArrA[col];
            n += ArrB[col];
            while (true)
            {
                if (m >= 0 && m <= Cons.size_Chessboard_Height && n >= 0 &&
                n <= Cons.size_Chessboard_Width && Matrix[m][n].Text.Contains(temp))
                {
                    m += ArrA[col];
                    n += ArrB[col];
                    count++;
                }
                else
                    return count;
            }  
        }
    }
}
