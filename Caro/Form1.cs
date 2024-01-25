using System.Drawing.Drawing2D;
using System;

namespace Caro
{
    public partial class Form1 : Form
    {
        BuildChecssBoard buildChecssBoard;

        public Form1()
        {
            InitializeComponent();
            buildChecssBoard = new BuildChecssBoard(lblScorePlayer1, lblScorePlayer2);
           // buildChecssBoard.DrawChessboard(PanelChessBoard);
            Menu.New_Game(buildChecssBoard, PanelChessBoard);
            //progressBar1.Step = Cons.step;
            //progressBar1.Maximum = Cons.end_time;
            //progressBar1.Value = 0;
            //timer1.Interval = Cons.interval;
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //  progressBar1.PerformStep();
        }

        private void newGameCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu.New_Game(buildChecssBoard, PanelChessBoard);
        }

        private void undoCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Menu.Undo(buildChecssBoard.Matrix, buildChecssBoard.ListRowed, buildChecssBoard.ListColed);
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