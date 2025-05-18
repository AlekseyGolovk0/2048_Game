namespace _2048GameWinFormsApp
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
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            rulesToolStripMenuItem = new ToolStripMenuItem();
            resultToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            scoreNameLabel = new Label();
            scoreLabel = new Label();
            bestScoreLabel = new Label();
            bestScoreNameLabel = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(586, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartToolStripMenuItem, rulesToolStripMenuItem, resultToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(138, 22);
            restartToolStripMenuItem.Text = "Перезапуск";
            restartToolStripMenuItem.Click += RrestartToolStripMenuItem_Click;
            // 
            // rulesToolStripMenuItem
            // 
            rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            rulesToolStripMenuItem.Size = new Size(138, 22);
            rulesToolStripMenuItem.Text = "Правила";
            rulesToolStripMenuItem.Click += RulesToolStripMenuItem_Click;
            // 
            // resultToolStripMenuItem
            // 
            resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            resultToolStripMenuItem.Size = new Size(138, 22);
            resultToolStripMenuItem.Text = "Результаты";
            resultToolStripMenuItem.Click += ResultToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(138, 22);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // scoreNameLabel
            // 
            scoreNameLabel.AutoSize = true;
            scoreNameLabel.Location = new Point(12, 35);
            scoreNameLabel.Name = "scoreNameLabel";
            scoreNameLabel.Size = new Size(36, 15);
            scoreNameLabel.TabIndex = 2;
            scoreNameLabel.Text = "Счет:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(66, 35);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(13, 15);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "0";
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.AutoSize = true;
            bestScoreLabel.Location = new Point(246, 35);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(13, 15);
            bestScoreLabel.TabIndex = 5;
            bestScoreLabel.Text = "0";
            // 
            // bestScoreNameLabel
            // 
            bestScoreNameLabel.AutoSize = true;
            bestScoreNameLabel.Location = new Point(128, 35);
            bestScoreNameLabel.Name = "bestScoreNameLabel";
            bestScoreNameLabel.Size = new Size(112, 15);
            bestScoreNameLabel.TabIndex = 4;
            bestScoreNameLabel.Text = "Лучший результат:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(586, 555);
            Controls.Add(bestScoreLabel);
            Controls.Add(bestScoreNameLabel);
            Controls.Add(scoreLabel);
            Controls.Add(scoreNameLabel);
            Controls.Add(menuStrip);
            ForeColor = Color.FromArgb(64, 64, 64);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Игра 2048";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private ToolStripMenuItem resultToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label scoreNameLabel;
        private Label scoreLabel;
        private Label bestScoreLabel;
        private Label bestScoreNameLabel;
    }
}
