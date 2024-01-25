namespace Caro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lblScorePlayer1 = new Label();
            lblScorePlayer2 = new Label();
            label5 = new Label();
            lblX = new Label();
            lblO = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newGameCtrlNToolStripMenuItem = new ToolStripMenuItem();
            undoCtrlZToolStripMenuItem = new ToolStripMenuItem();
            quitCtrlWToolStripMenuItem = new ToolStripMenuItem();
            PanelChessBoard = new Panel();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(357, 24);
            label1.Name = "label1";
            label1.Size = new Size(107, 27);
            label1.TabIndex = 1;
            label1.Text = "Player 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(688, 24);
            label2.Name = "label2";
            label2.Size = new Size(109, 27);
            label2.TabIndex = 2;
            label2.Text = "Player 2";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(357, 66);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(170, 27);
            progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(627, 66);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(170, 27);
            progressBar2.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblScorePlayer1
            // 
            lblScorePlayer1.AutoSize = true;
            lblScorePlayer1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblScorePlayer1.Location = new Point(540, 24);
            lblScorePlayer1.Name = "lblScorePlayer1";
            lblScorePlayer1.Size = new Size(24, 28);
            lblScorePlayer1.TabIndex = 5;
            lblScorePlayer1.Text = "0";
            // 
            // lblScorePlayer2
            // 
            lblScorePlayer2.AutoSize = true;
            lblScorePlayer2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblScorePlayer2.Location = new Point(590, 24);
            lblScorePlayer2.Name = "lblScorePlayer2";
            lblScorePlayer2.Size = new Size(24, 28);
            lblScorePlayer2.TabIndex = 6;
            lblScorePlayer2.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(568, 24);
            label5.Name = "label5";
            label5.Size = new Size(17, 28);
            label5.TabIndex = 7;
            label5.Text = ":";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblX.ForeColor = Color.Red;
            lblX.Location = new Point(496, 24);
            lblX.Name = "lblX";
            lblX.Size = new Size(28, 27);
            lblX.TabIndex = 2;
            lblX.Text = "X";
            // 
            // lblO
            // 
            lblO.AutoSize = true;
            lblO.Font = new Font("Lucida Calligraphy", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblO.ForeColor = Color.Red;
            lblO.Location = new Point(627, 24);
            lblO.Name = "lblO";
            lblO.Size = new Size(29, 27);
            lblO.TabIndex = 8;
            lblO.Text = "O";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PaleTurquoise;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1193, 33);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameCtrlNToolStripMenuItem, undoCtrlZToolStripMenuItem, quitCtrlWToolStripMenuItem });
            menuToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(72, 29);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameCtrlNToolStripMenuItem
            // 
            newGameCtrlNToolStripMenuItem.Name = "newGameCtrlNToolStripMenuItem";
            newGameCtrlNToolStripMenuItem.Size = new Size(302, 34);
            newGameCtrlNToolStripMenuItem.Text = "New game       Ctrl + N";
            newGameCtrlNToolStripMenuItem.Click += newGameCtrlNToolStripMenuItem_Click;
            // 
            // undoCtrlZToolStripMenuItem
            // 
            undoCtrlZToolStripMenuItem.Name = "undoCtrlZToolStripMenuItem";
            undoCtrlZToolStripMenuItem.Size = new Size(302, 34);
            undoCtrlZToolStripMenuItem.Text = "Undo               Ctrl + Z";
            undoCtrlZToolStripMenuItem.Click += undoCtrlZToolStripMenuItem_Click;
            // 
            // quitCtrlWToolStripMenuItem
            // 
            quitCtrlWToolStripMenuItem.Name = "quitCtrlWToolStripMenuItem";
            quitCtrlWToolStripMenuItem.Size = new Size(302, 34);
            quitCtrlWToolStripMenuItem.Text = "Quit                 Ctrl + W";
            quitCtrlWToolStripMenuItem.Click += quitCtrlWToolStripMenuItem_Click;
            // 
            // PanelChessBoard
            // 
            PanelChessBoard.BackColor = Color.Cornsilk;
            PanelChessBoard.Dock = DockStyle.Bottom;
            PanelChessBoard.Location = new Point(0, 116);
            PanelChessBoard.Name = "PanelChessBoard";
            PanelChessBoard.Size = new Size(1193, 643);
            PanelChessBoard.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1193, 759);
            Controls.Add(PanelChessBoard);
            Controls.Add(lblO);
            Controls.Add(lblX);
            Controls.Add(label5);
            Controls.Add(lblScorePlayer2);
            Controls.Add(lblScorePlayer1);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Caro";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer1;
        private Label lblScorePlayer1;
        private Label lblScorePlayer2;
        private Label label5;
        private Label lblX;
        private Label lblO;
        private FileSystemWatcher fileSystemWatcher1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newGameCtrlNToolStripMenuItem;
        private ToolStripMenuItem undoCtrlZToolStripMenuItem;
        private ToolStripMenuItem quitCtrlWToolStripMenuItem;
        private Panel PanelChessBoard;
    }
}