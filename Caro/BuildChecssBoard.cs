using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Caro
{
    internal class BuildChecssBoard
    {
        private Label lblX, lblO;
        private List<List<Button>> matrix;
        Stack<int>  listRowed, listColed;
        private bool check_X = true, check_O = false;

        public BuildChecssBoard()  { }
        public BuildChecssBoard(Label lblX, Label lblO) 
        {
            LblX = lblX;
            LblO = lblO;
        }

        public Label LblX { get => lblX; set => lblX = value; }
        public Label LblO { get => lblO; set => lblO = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        public Stack<int> ListRowed { get => listRowed; set => listRowed = value; }
        public Stack<int> ListColed { get => listColed; set => listColed = value; }

        public void DrawChessboard(Panel PanelChessBoard)
        {
            ListRowed = new Stack<int>();
            ListColed = new Stack<int>();
            Matrix = new List<List<Button>>();
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0)};
            for (int i = 0; i <= Cons.size_Chessboard_Height; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j <= Cons.size_Chessboard_Width; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.chess_Width,
                        Height = Cons.chess_Height,
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.White,
                        Font = new Font(oldbtn.Font.FontFamily , 1, oldbtn.Font.Style)
                    };
                    PanelChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                    btn.Click += btn_Click;
                    Matrix[i].Add(btn);
                }
                oldbtn.Width = 0;
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Cons.chess_Height);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
          
            Button btn = sender as Button;
            if (check_X)
            {
                if (btn.BackgroundImage == null)
                {
                    btn.BackgroundImage = Image.FromFile("D:\\CODE\\C#\\Caro\\x.png");
                    btn.Text = ",";
                    check_X = false;
                    check_O = true;
                    isEndGame end = new isEndGame(Matrix);
                    if (end.check_win(btn))
                    {
                        MessageBox.Show("X is winer");
                        LblX.Text = (Int32.Parse(LblX.Text) + 1).ToString();
                    }
                }
            }
            if (check_O)
            {
                if (btn.BackgroundImage == null)
                {
                    btn.BackgroundImage = Image.FromFile("D:\\CODE\\C#\\Caro\\o.png");
                    btn.Text = ".";
                    check_X = true;
                    check_O = false;
                    isEndGame end = new isEndGame(Matrix);
                    if (end.check_win(btn))
                    {
                        MessageBox.Show("O is winer");
                        LblO.Text = (Int32.Parse(LblO.Text) + 1).ToString();
                    }
                }
            }
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            Index index = new Index(Matrix);
            Index idx = index.GetIndex(btn);
            ListRowed.Push(idx.X);
            ListColed.Push(idx.Y);
        }
    }
}
