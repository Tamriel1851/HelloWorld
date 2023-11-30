namespace oneillogame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gameMenuStrip = new MenuStrip();
            menuStripGame = new ToolStripMenuItem();
            menuStartGame = new ToolStripMenuItem();
            menuSaveGame = new ToolStripMenuItem();
            menuRestoreGame = new ToolStripMenuItem();
            menuExitGame = new ToolStripMenuItem();
            menuStripSettings = new ToolStripMenuItem();
            menuInformationPanel = new ToolStripMenuItem();
            menuSpeak = new ToolStripMenuItem();
            menuStripHelp = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();
            playersGameStat = new Panel();
            playerIndicator2 = new PictureBox();
            playerIndicator = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            playerBlackX = new Label();
            playerWhiteX = new Label();
            playerBlackNumberOfTokens = new Label();
            playerWhiteNumberOfTokens = new Label();
            playerBlackName = new TextBox();
            playerWhiteName = new TextBox();
            gameMenuStrip.SuspendLayout();
            playersGameStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerIndicator2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerIndicator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gameMenuStrip
            // 
            gameMenuStrip.Items.AddRange(new ToolStripItem[] { menuStripGame, menuStripSettings, menuStripHelp });
            gameMenuStrip.Location = new Point(0, 0);
            gameMenuStrip.Name = "gameMenuStrip";
            gameMenuStrip.Size = new Size(817, 24);
            gameMenuStrip.TabIndex = 0;
            gameMenuStrip.Text = "menuStrip1";
            // 
            // menuStripGame
            // 
            menuStripGame.DropDownItems.AddRange(new ToolStripItem[] { menuStartGame, menuSaveGame, menuRestoreGame, menuExitGame });
            menuStripGame.Name = "menuStripGame";
            menuStripGame.Size = new Size(50, 20);
            menuStripGame.Text = "&Game";
            menuStripGame.Click += menuGame_Click;
            // 
            // menuStartGame
            // 
            menuStartGame.Name = "menuStartGame";
            menuStartGame.Size = new Size(147, 22);
            menuStartGame.Text = "&Start Game";
            menuStartGame.Click += menuStartGame_Click;
            // 
            // menuSaveGame
            // 
            menuSaveGame.Name = "menuSaveGame";
            menuSaveGame.Size = new Size(147, 22);
            menuSaveGame.Text = "Save Game";
            menuSaveGame.Click += menuSaveGame_Click;
            // 
            // menuRestoreGame
            // 
            menuRestoreGame.Name = "menuRestoreGame";
            menuRestoreGame.Size = new Size(147, 22);
            menuRestoreGame.Text = "Restore Game";
            menuRestoreGame.Click += menuRestoreGame_Click;
            // 
            // menuExitGame
            // 
            menuExitGame.Name = "menuExitGame";
            menuExitGame.Size = new Size(147, 22);
            menuExitGame.Text = "E&xit Game";
            menuExitGame.Click += menuExitGame_Click;
            // 
            // menuStripSettings
            // 
            menuStripSettings.DropDownItems.AddRange(new ToolStripItem[] { menuInformationPanel, menuSpeak });
            menuStripSettings.Name = "menuStripSettings";
            menuStripSettings.Size = new Size(61, 20);
            menuStripSettings.Text = "&Settings";
            menuStripSettings.Click += menuStripSettings_Click;
            // 
            // menuInformationPanel
            // 
            menuInformationPanel.Name = "menuInformationPanel";
            menuInformationPanel.Size = new Size(169, 22);
            menuInformationPanel.Text = "&Information Panel";
            menuInformationPanel.Click += menuInformationPanel_Click;
            // 
            // menuSpeak
            // 
            menuSpeak.Name = "menuSpeak";
            menuSpeak.Size = new Size(169, 22);
            menuSpeak.Text = "&Speak";
            menuSpeak.Click += menuSpeak_Click;
            // 
            // menuStripHelp
            // 
            menuStripHelp.DropDownItems.AddRange(new ToolStripItem[] { menuAbout });
            menuStripHelp.Name = "menuStripHelp";
            menuStripHelp.Size = new Size(44, 20);
            menuStripHelp.Text = "&Help";
            menuStripHelp.Click += menuStripHelp_Click;
            // 
            // menuAbout
            // 
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new Size(107, 22);
            menuAbout.Text = "&About";
            menuAbout.Click += menuAbout_Click;
            // 
            // playersGameStat
            // 
            playersGameStat.BackColor = Color.IndianRed;
            playersGameStat.BorderStyle = BorderStyle.Fixed3D;
            playersGameStat.Controls.Add(playerIndicator2);
            playersGameStat.Controls.Add(playerIndicator);
            playersGameStat.Controls.Add(pictureBox2);
            playersGameStat.Controls.Add(pictureBox1);
            playersGameStat.Controls.Add(playerBlackX);
            playersGameStat.Controls.Add(playerWhiteX);
            playersGameStat.Controls.Add(playerBlackNumberOfTokens);
            playersGameStat.Controls.Add(playerWhiteNumberOfTokens);
            playersGameStat.Controls.Add(playerBlackName);
            playersGameStat.Controls.Add(playerWhiteName);
            playersGameStat.Location = new Point(24, 519);
            playersGameStat.Name = "playersGameStat";
            playersGameStat.Size = new Size(762, 92);
            playersGameStat.TabIndex = 2;
            // 
            // playerIndicator2
            // 
            playerIndicator2.Image = Properties.Resources.Pointer1;
            playerIndicator2.Location = new Point(600, 11);
            playerIndicator2.Name = "playerIndicator2";
            playerIndicator2.Size = new Size(77, 37);
            playerIndicator2.SizeMode = PictureBoxSizeMode.Zoom;
            playerIndicator2.TabIndex = 11;
            playerIndicator2.TabStop = false;
            // 
            // playerIndicator
            // 
            playerIndicator.Image = Properties.Resources.Pointer1;
            playerIndicator.Location = new Point(205, 11);
            playerIndicator.Name = "playerIndicator";
            playerIndicator.Size = new Size(77, 37);
            playerIndicator.SizeMode = PictureBoxSizeMode.Zoom;
            playerIndicator.TabIndex = 8;
            playerIndicator.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.black_on_square;
            pictureBox2.Location = new Point(89, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_on_square;
            pictureBox1.Location = new Point(468, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // playerBlackX
            // 
            playerBlackX.AutoSize = true;
            playerBlackX.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            playerBlackX.Location = new Point(442, 60);
            playerBlackX.Name = "playerBlackX";
            playerBlackX.Size = new Size(20, 21);
            playerBlackX.TabIndex = 7;
            playerBlackX.Text = "X";
            // 
            // playerWhiteX
            // 
            playerWhiteX.AutoSize = true;
            playerWhiteX.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            playerWhiteX.Location = new Point(62, 60);
            playerWhiteX.Name = "playerWhiteX";
            playerWhiteX.Size = new Size(20, 21);
            playerWhiteX.TabIndex = 6;
            playerWhiteX.Text = "X";
            // 
            // playerBlackNumberOfTokens
            // 
            playerBlackNumberOfTokens.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            playerBlackNumberOfTokens.Location = new Point(378, 39);
            playerBlackNumberOfTokens.Name = "playerBlackNumberOfTokens";
            playerBlackNumberOfTokens.Size = new Size(67, 38);
            playerBlackNumberOfTokens.TabIndex = 5;
            playerBlackNumberOfTokens.Text = "2";
            playerBlackNumberOfTokens.TextChanged += playerBlackNumberOfTokens_Click;
            // 
            // playerWhiteNumberOfTokens
            // 
            playerWhiteNumberOfTokens.BackColor = Color.IndianRed;
            playerWhiteNumberOfTokens.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            playerWhiteNumberOfTokens.Location = new Point(3, 40);
            playerWhiteNumberOfTokens.Name = "playerWhiteNumberOfTokens";
            playerWhiteNumberOfTokens.Size = new Size(66, 41);
            playerWhiteNumberOfTokens.TabIndex = 4;
            playerWhiteNumberOfTokens.Text = "2";
            playerWhiteNumberOfTokens.TextChanged += playerWhiteNumberOfTokens_Click;
            playerWhiteNumberOfTokens.Click += playerWhiteNumberOfTokens_Click;
            // 
            // playerBlackName
            // 
            playerBlackName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            playerBlackName.Location = new Point(533, 54);
            playerBlackName.Name = "playerBlackName";
            playerBlackName.Size = new Size(214, 27);
            playerBlackName.TabIndex = 2;
            playerBlackName.TextAlign = HorizontalAlignment.Center;
            playerBlackName.TextChanged += playerBlackName_TextChanged;
            // 
            // playerWhiteName
            // 
            playerWhiteName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            playerWhiteName.Location = new Point(154, 54);
            playerWhiteName.Name = "playerWhiteName";
            playerWhiteName.Size = new Size(183, 27);
            playerWhiteName.TabIndex = 1;
            playerWhiteName.TextAlign = HorizontalAlignment.Center;
            playerWhiteName.TextChanged += playerWhiteName_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(817, 613);
            Controls.Add(playersGameStat);
            Controls.Add(gameMenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = gameMenuStrip;
            Name = "Form1";
            Text = "O'Neillo Game";
            Load += Form1_Load;
            gameMenuStrip.ResumeLayout(false);
            gameMenuStrip.PerformLayout();
            playersGameStat.ResumeLayout(false);
            playersGameStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playerIndicator2).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerIndicator).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip gameMenuStrip;
        private ToolStripMenuItem menuStripSettings;
        private ToolStripMenuItem menuStripHelp;
        private Panel playersGameStat;
        private TextBox playerBlackName;
        private TextBox playerWhiteName;
        private Label playerBlackX;
        private Label playerWhiteX;
        private Label playerBlackNumberOfTokens;
        private Label playerWhiteNumberOfTokens;
        private ToolStripMenuItem menuStartGame;
        private ToolStripMenuItem menuInformationPanel;
        private ToolStripMenuItem menuAbout;
        private ToolStripMenuItem menuStripGame;
        private ToolStripMenuItem menuExitGame;
        private ToolStripMenuItem menuSpeak;
        private PictureBox playerIndicator;
        private ToolStripMenuItem menuRestoreGame;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox playerIndicator2;
        private ToolStripMenuItem menuSaveGame;
    }

}