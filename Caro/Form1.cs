using System.Drawing.Drawing2D;
using System;

namespace Caro
{
    public partial class Form1 : Form
    {
        BuildChecssBoard buildChecssBoard;
        Menu menu;
        public Form1()
        {
            InitializeComponent();
           
            buildChecssBoard = new BuildChecssBoard(PanelChessBoard, lblScorePlayer1, lblScorePlayer2);
            menu = new Menu(buildChecssBoard, PanelChessBoard);
            menu.New_Game();
            this.KeyDown += Form_KeyDown;
            // buildChecssBoard.DrawChessboard(PanelChessBoard);
            //   Menu.New_Game(buildChecssBoard, PanelChessBoard);
            //progressBar1.Step = Cons.step;
            //progressBar1.Maximum = Cons.end_time;
            //progressBar1.Value = 0;
            //timer1.Interval = Cons.interval;
            //timer1.Start();
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                menu.Undo();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //  progressBar1.PerformStep();
        }

        private void newGameCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu.New_Game();
        }

        private void undoCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu.Undo();
        }

        private void quitCtrlWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}