namespace Week06Worksheet
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
            numberInputField = new RichTextBox();
            saveDataButton = new Button();
            SuspendLayout();
            // 
            // numberInputField
            // 
            numberInputField.Location = new Point(28, 23);
            numberInputField.Name = "numberInputField";
            numberInputField.Size = new Size(748, 325);
            numberInputField.TabIndex = 1;
            numberInputField.Text = "";
            numberInputField.TextChanged += numberInputField_TextChanged;
            // 
            // saveDataButton
            // 
            saveDataButton.Location = new Point(280, 364);
            saveDataButton.Name = "saveDataButton";
            saveDataButton.Size = new Size(279, 56);
            saveDataButton.TabIndex = 2;
            saveDataButton.Text = "Save Data";
            saveDataButton.UseVisualStyleBackColor = true;
            saveDataButton.Click += saveDataButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveDataButton);
            Controls.Add(numberInputField);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox numberInputField;
        private Button saveDataButton;
    }
}