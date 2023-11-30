namespace oneillogame
{
    partial class AboutPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPage));
            aboutPageOkButton = new Button();
            labelGameName = new Label();
            aboutTheGameInfo = new RichTextBox();
            pictureBox1 = new PictureBox();
            informationBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            informationBox.SuspendLayout();
            SuspendLayout();
            // 
            // aboutPageOkButton
            // 
            aboutPageOkButton.Location = new Point(289, 406);
            aboutPageOkButton.Name = "aboutPageOkButton";
            aboutPageOkButton.Size = new Size(133, 42);
            aboutPageOkButton.TabIndex = 5;
            aboutPageOkButton.Text = "OK";
            aboutPageOkButton.UseVisualStyleBackColor = true;
            aboutPageOkButton.Click += aboutPageOkButton_Click;
            // 
            // labelGameName
            // 
            labelGameName.AutoSize = true;
            labelGameName.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelGameName.Location = new Point(409, 54);
            labelGameName.Name = "labelGameName";
            labelGameName.Size = new Size(176, 100);
            labelGameName.TabIndex = 5;
            labelGameName.Text = "O'Neillo \r\n  Game";
            labelGameName.Click += labelGameName_Click;
            // 
            // aboutTheGameInfo
            // 
            aboutTheGameInfo.BackColor = SystemColors.GradientInactiveCaption;
            aboutTheGameInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            aboutTheGameInfo.Location = new Point(349, 172);
            aboutTheGameInfo.Name = "aboutTheGameInfo";
            aboutTheGameInfo.Size = new Size(270, 175);
            aboutTheGameInfo.TabIndex = 6;
            aboutTheGameInfo.Text = "";
            aboutTheGameInfo.TextChanged += aboutTheGameInfo_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.About_page_21;
            pictureBox1.Location = new Point(26, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 315);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // informationBox
            // 
            informationBox.BackgroundImageLayout = ImageLayout.Center;
            informationBox.Controls.Add(pictureBox1);
            informationBox.Controls.Add(aboutTheGameInfo);
            informationBox.Controls.Add(labelGameName);
            informationBox.FlatStyle = FlatStyle.Popup;
            informationBox.Location = new Point(21, 10);
            informationBox.Name = "informationBox";
            informationBox.Size = new Size(659, 390);
            informationBox.TabIndex = 6;
            informationBox.TabStop = false;
            informationBox.Enter += informationBox_Enter;
            // 
            // AboutPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(708, 451);
            Controls.Add(informationBox);
            Controls.Add(aboutPageOkButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutPage";
            Text = "About";
            Load += AboutPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            informationBox.ResumeLayout(false);
            informationBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button aboutPageOkButton;
        private Label labelGameName;
        private RichTextBox aboutTheGameInfo;
        private PictureBox pictureBox1;
        private GroupBox informationBox;
    }
}