namespace TicTacToeGame
{
    partial class MainForm
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
            lblTitle = new Label();
            lblStatus = new Label();
            gameBoardPanel = new TableLayoutPanel();
            btn00 = new Button();
            btn01 = new Button();
            btn02 = new Button();
            btn10 = new Button();
            btn11 = new Button();
            btn12 = new Button();
            btn20 = new Button();
            btn21 = new Button();
            btn22 = new Button();
            btnNewGame = new Button();
            gameBoardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.Location = new Point(101, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(212, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tic Tac Toe";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStatus.Location = new Point(124, 78);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(153, 28);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Player X's Turn";
            // 
            // gameBoardPanel
            // 
            gameBoardPanel.ColumnCount = 3;
            gameBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            gameBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            gameBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            gameBoardPanel.Controls.Add(btn00, 0, 0);
            gameBoardPanel.Controls.Add(btn01, 1, 0);
            gameBoardPanel.Controls.Add(btn02, 2, 0);
            gameBoardPanel.Controls.Add(btn10, 0, 1);
            gameBoardPanel.Controls.Add(btn11, 1, 1);
            gameBoardPanel.Controls.Add(btn12, 2, 1);
            gameBoardPanel.Controls.Add(btn20, 0, 2);
            gameBoardPanel.Controls.Add(btn21, 1, 2);
            gameBoardPanel.Controls.Add(btn22, 2, 2);
            gameBoardPanel.Location = new Point(73, 160);
            gameBoardPanel.Name = "gameBoardPanel";
            gameBoardPanel.RowCount = 3;
            gameBoardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            gameBoardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            gameBoardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            gameBoardPanel.Size = new Size(249, 240);
            gameBoardPanel.TabIndex = 2;
            // 
            // btn00
            // 
            btn00.Dock = DockStyle.Fill;
            btn00.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn00.Location = new Point(3, 3);
            btn00.Name = "btn00";
            btn00.Size = new Size(77, 73);
            btn00.TabIndex = 0;
            btn00.TabStop = false;
            btn00.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            btn01.Dock = DockStyle.Fill;
            btn01.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn01.Location = new Point(86, 3);
            btn01.Name = "btn01";
            btn01.Size = new Size(77, 73);
            btn01.TabIndex = 1;
            btn01.TabStop = false;
            btn01.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            btn02.Dock = DockStyle.Fill;
            btn02.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn02.Location = new Point(169, 3);
            btn02.Name = "btn02";
            btn02.Size = new Size(77, 73);
            btn02.TabIndex = 2;
            btn02.TabStop = false;
            btn02.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            btn10.Dock = DockStyle.Fill;
            btn10.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn10.Location = new Point(3, 82);
            btn10.Name = "btn10";
            btn10.Size = new Size(77, 73);
            btn10.TabIndex = 3;
            btn10.TabStop = false;
            btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            btn11.Dock = DockStyle.Fill;
            btn11.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn11.Location = new Point(86, 82);
            btn11.Name = "btn11";
            btn11.Size = new Size(77, 73);
            btn11.TabIndex = 4;
            btn11.TabStop = false;
            btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            btn12.Dock = DockStyle.Fill;
            btn12.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn12.Location = new Point(169, 82);
            btn12.Name = "btn12";
            btn12.Size = new Size(77, 73);
            btn12.TabIndex = 5;
            btn12.TabStop = false;
            btn12.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            btn20.Dock = DockStyle.Fill;
            btn20.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn20.Location = new Point(3, 161);
            btn20.Name = "btn20";
            btn20.Size = new Size(77, 76);
            btn20.TabIndex = 6;
            btn20.TabStop = false;
            btn20.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            btn21.Dock = DockStyle.Fill;
            btn21.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn21.Location = new Point(86, 161);
            btn21.Name = "btn21";
            btn21.Size = new Size(77, 76);
            btn21.TabIndex = 7;
            btn21.TabStop = false;
            btn21.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            btn22.Dock = DockStyle.Fill;
            btn22.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            btn22.Location = new Point(169, 161);
            btn22.Name = "btn22";
            btn22.Size = new Size(77, 76);
            btn22.TabIndex = 8;
            btn22.TabStop = false;
            btn22.UseVisualStyleBackColor = true;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNewGame.Location = new Point(136, 421);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(120, 40);
            btnNewGame.TabIndex = 3;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 473);
            Controls.Add(btnNewGame);
            Controls.Add(gameBoardPanel);
            Controls.Add(lblStatus);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            gameBoardPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStatus;
        private TableLayoutPanel gameBoardPanel;
        private Button btn00;
        private Button btn01;
        private Button btn02;
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private Button btn20;
        private Button btn21;
        private Button btn22;
        private Button btnNewGame;
    }
}
