using System.Data.SqlClient;

namespace WinFormsApp3
{
    public partial class CRUDForm : Form
    {
        private string CONN_STRING = GetDbConnectionString();
        internal string messageBoxText;
        internal SqlConnection connection;
        internal SqlDataAdapter adapter;
        internal SqlCommand command;

        public CRUDForm()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;

            // Instantiate a connection object,
            // using the connection string to the database
            connection = new SqlConnection(CONN_STRING);
        }

        // In the lecture, I could not connect to the database file,
        // because I forgot I has made this solution on my personal computer
        // so the file path was relative to my machine.
        // This method solves that problem by first finding the directory
        // where the project file is located, then appends the rest of 
        // the path to the end of that, then uses that path in the connection string
        private static string GetDbConnectionString()
        {
            string solutionDir = "";
            DirectoryInfo currentDir = Directory.GetParent(".")!; // dot means current directory
                                                                  // The ! is used to tell the
                                                                  // compiler that I am aware it
                                                                  // can be null and I am taking 
                                                                  // responsibility for that.
            while (solutionDir.Length == 0)
            {
                FileInfo[] files = currentDir.GetFiles();
                foreach (FileInfo file in files)
                    if (file.Name.EndsWith(".csproj"))
                    {
                        solutionDir = currentDir.FullName;
                        break;
                    }
                if (solutionDir.Length == 0)
                {
                    currentDir = currentDir.Parent!;
                }
                else break;
                
            }

            string dbFilePath = $"{solutionDir}\\db\\Tournament.mdf";
            return $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{dbFilePath}\";Integrated Security=True;Connect Timeout=30"; ;
        }

        internal void btnOpenConnection_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                messageBoxText = "The connection is already open!";
                MessageBox.Show(messageBoxText);
                return;
            }

            // Open the database connection before
            // using it.
            connection.Open();

            messageBoxText = "Database Connection opened!";
            MessageBox.Show(messageBoxText);
        }

        internal void btnCreate_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                messageBoxText = "Open connection before creating...";
                MessageBox.Show(messageBoxText);
                return;
            }

            if (txtNewName.Text.Trim().Length == 0 || txtNewCountry.Text.Trim().Length == 0)
            {
                MessageBox.Show("Enter the participant's name and country before trying to create a new record.");
                return;
            }

            string createQuery = $"Insert into Participant values ('{txtNewName.Text}', '{txtNewCountry.Text}')";

            // Data Adapters are used to run
            // insert, updates and delete commands
            adapter = new SqlDataAdapter();

            // An adapter will need a command object
            // to do its thing. The command object
            // needs an open connection
            command = new SqlCommand(createQuery, connection);
            adapter.InsertCommand = command;
            
            int rowsAffected = adapter.InsertCommand.ExecuteNonQuery();
            

            messageBoxText = $"Inserted {rowsAffected} rows of data.";
            MessageBox.Show(messageBoxText);
        }

        internal void btnRead_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                messageBoxText = "Open connection before reading...";
                MessageBox.Show(messageBoxText);
                return;
            }

            string readQuery = "Select Id, Name, Country from Participant";

            // Create a SqlCommand object, which uses an open
            // connection to execute the provided SQL query
            SqlCommand command = new SqlCommand(readQuery, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            dgvParticipants.Rows.Clear();

            while (dataReader.Read())
            {
                dgvParticipants.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2));
            }

            // Close the data reader after using it
            dataReader.Close();
        }

        internal void btnUpdate_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                messageBoxText = "Open connection before updating...";
                MessageBox.Show(messageBoxText);
                return;
            }

            if ((dgvParticipants.Rows.Count == 0 || dgvParticipants.SelectedRows.Count == 0)
                && (txtUpdateName.Text.Trim().Length == 0 || txtUpdateCountry.Text.Trim().Length == 0))
            {

                MessageBox.Show("Select the item you want to update, and provide name and country");
                return;
            }

            DataGridViewRow selectedRow = dgvParticipants.SelectedRows[0];
            string updateQuery = $"Update Participant set Name='{txtUpdateName.Text}', Country='{txtUpdateCountry.Text}' Where Id = {Convert.ToInt32(selectedRow.Cells[0].Value)};";

            // Data Adapters are used to run
            // insert, updates and delete commands
            adapter = new SqlDataAdapter();

            // An adapter will need a command object
            // to do its thing. The command object
            // needs an open connection

            command = new SqlCommand(updateQuery, connection);
            adapter.UpdateCommand = command;

            int rowsAffected = adapter.UpdateCommand.ExecuteNonQuery();

            messageBoxText = $"Updated {rowsAffected} rows of data.";
            MessageBox.Show(messageBoxText);
        }

        internal void btnDelete_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                messageBoxText = "Open connection before deleting...";
                MessageBox.Show(messageBoxText);
                return;
            }

            if ((dgvParticipants.Rows.Count == 0 || dgvParticipants.SelectedRows.Count == 0)
                && (txtUpdateName.Text.Trim().Length == 0 || txtUpdateCountry.Text.Trim().Length == 0))
            {

                MessageBox.Show("Select the item you want to delete before trying to delete it.");
                return;
            }

            DataGridViewRow selectedRow = dgvParticipants.SelectedRows[0];
            string deleteQuery = $"Delete from Participant where Id = {Convert.ToInt32(selectedRow.Cells[0].Value)}";

            // Data Adapters are used to run
            // insert, updates and delete commands
            adapter = new SqlDataAdapter();

            // An adapter will need a command object
            // to do its thing. The command object
            // needs an open connection
            command = new SqlCommand(deleteQuery, connection);
            adapter.UpdateCommand = command;

            int rowsAffected = adapter.UpdateCommand.ExecuteNonQuery();

            messageBoxText = $"Deleted {rowsAffected} rows of data.";
            MessageBox.Show(messageBoxText);
        }

        internal void btnCloseConnection_Click(object sender, EventArgs e)
        {
            // Remember to close a connection to a database when
            // you are no longer going to be using it,
            // otherwise, you are holding up valuable
            // connection resource
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                messageBoxText = "The connection is already closed!";
                MessageBox.Show(messageBoxText);
                return;
            }

            connection.Close();

            messageBoxText = $"Database connection closed!";
            MessageBox.Show(messageBoxText);
        }

        internal void dgvParticipants_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvParticipants.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvParticipants.SelectedRows[0];

                // Access the values of the selected row using the Cells property
                txtUpdateName.Text = selectedRow.Cells[1].Value.ToString();
                txtUpdateCountry.Text = selectedRow.Cells[2].Value.ToString();
            }

        }

    }
}