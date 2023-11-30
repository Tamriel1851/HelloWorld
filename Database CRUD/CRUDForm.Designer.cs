namespace WinFormsApp3
{
    partial class CRUDForm
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
            btnCreate = new Button();
            btnRead = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtNewName = new TextBox();
            txtNewCountry = new TextBox();
            txtUpdateCountry = new TextBox();
            txtUpdateName = new TextBox();
            btnOpenConnection = new Button();
            btnCloseConnection = new Button();
            dgvParticipants = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ParticipantName = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 60);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(12, 108);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(94, 29);
            btnRead.TabIndex = 1;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 309);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 355);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtNewName
            // 
            txtNewName.Location = new Point(134, 64);
            txtNewName.Name = "txtNewName";
            txtNewName.PlaceholderText = "Name";
            txtNewName.Size = new Size(183, 27);
            txtNewName.TabIndex = 2;
            // 
            // txtNewCountry
            // 
            txtNewCountry.Location = new Point(352, 64);
            txtNewCountry.Name = "txtNewCountry";
            txtNewCountry.PlaceholderText = "Country";
            txtNewCountry.Size = new Size(183, 27);
            txtNewCountry.TabIndex = 3;
            // 
            // txtUpdateCountry
            // 
            txtUpdateCountry.Location = new Point(350, 311);
            txtUpdateCountry.Name = "txtUpdateCountry";
            txtUpdateCountry.PlaceholderText = "Country";
            txtUpdateCountry.Size = new Size(183, 27);
            txtUpdateCountry.TabIndex = 6;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(132, 311);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.PlaceholderText = "Name";
            txtUpdateName.Size = new Size(183, 27);
            txtUpdateName.TabIndex = 5;
            // 
            // btnOpenConnection
            // 
            btnOpenConnection.Location = new Point(133, 21);
            btnOpenConnection.Name = "btnOpenConnection";
            btnOpenConnection.Size = new Size(184, 29);
            btnOpenConnection.TabIndex = 7;
            btnOpenConnection.Text = "Open Connection";
            btnOpenConnection.UseVisualStyleBackColor = true;
            btnOpenConnection.Click += btnOpenConnection_Click;
            // 
            // btnCloseConnection
            // 
            btnCloseConnection.Location = new Point(349, 21);
            btnCloseConnection.Name = "btnCloseConnection";
            btnCloseConnection.Size = new Size(184, 29);
            btnCloseConnection.TabIndex = 8;
            btnCloseConnection.Text = "Close Connection";
            btnCloseConnection.UseVisualStyleBackColor = true;
            btnCloseConnection.Click += btnCloseConnection_Click;
            // 
            // dgvParticipants
            // 
            dgvParticipants.AllowUserToAddRows = false;
            dgvParticipants.AllowUserToDeleteRows = false;
            dgvParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipants.Columns.AddRange(new DataGridViewColumn[] { Id, ParticipantName, Country });
            dgvParticipants.Location = new Point(132, 108);
            dgvParticipants.Name = "dgvParticipants";
            dgvParticipants.ReadOnly = true;
            dgvParticipants.RowHeadersWidth = 51;
            dgvParticipants.RowTemplate.Height = 29;
            dgvParticipants.Size = new Size(496, 183);
            dgvParticipants.TabIndex = 9;
            dgvParticipants.SelectionChanged += dgvParticipants_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 40;
            // 
            // ParticipantName
            // 
            ParticipantName.HeaderText = "Name";
            ParticipantName.MinimumWidth = 6;
            ParticipantName.Name = "ParticipantName";
            ParticipantName.ReadOnly = true;
            ParticipantName.Width = 200;
            // 
            // Country
            // 
            Country.HeaderText = "Country";
            Country.MinimumWidth = 6;
            Country.Name = "Country";
            Country.ReadOnly = true;
            Country.Width = 200;
            // 
            // CRUDForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 396);
            Controls.Add(dgvParticipants);
            Controls.Add(btnCloseConnection);
            Controls.Add(btnOpenConnection);
            Controls.Add(txtUpdateCountry);
            Controls.Add(txtUpdateName);
            Controls.Add(txtNewCountry);
            Controls.Add(txtNewName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRead);
            Controls.Add(btnCreate);
            Name = "CRUDForm";
            Text = "Database CRUD";
            ((System.ComponentModel.ISupportInitialize)dgvParticipants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        internal Button btnCreate;
        internal Button btnRead;
        internal Button btnUpdate;
        internal Button btnDelete;
        internal TextBox txtNewName;
        internal TextBox txtNewCountry;
        internal TextBox txtUpdateCountry;
        internal TextBox txtUpdateName;
        internal Button btnOpenConnection;
        internal Button btnCloseConnection;
        internal DataGridView dgvParticipants;
        internal DataGridViewTextBoxColumn Id;
        internal DataGridViewTextBoxColumn ParticipantName;
        internal DataGridViewTextBoxColumn Country;
    }
}