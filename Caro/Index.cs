using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Caro
{
    internal class Index
    {
        private int x, y;
        List<List<Button>> matrix;
        private int i;
        private int j;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        public Index(List<List<Button>> matrix) 
        {
            Matrix = matrix;
        }
        public Index(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Index GetIndex(Button btn)
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                int j = Matrix[i].IndexOf(btn);
                if (j != -1)
                {
                    return new Index(i, j);
                }
            }
            return null;
        }
    }
}
