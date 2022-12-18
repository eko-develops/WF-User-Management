using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Data;

namespace UserManagementSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            FillDataGird();
        }

        private void FillDataGird()
        {
            SqliteConnection connection = new SqliteConnection("DataSource=database.db");

            string query = @"
                            SELECT * FROM User;
                            ";

            SqliteCommand command = new SqliteCommand(query, connection);

            connection.Open();

            SqliteDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();

            table.Load(reader);
            dataGridView.DataSource = table;

            reader.Close();
            connection.Close();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            // we are submitting the form here to the database
            // because we are in the UserManagementSystem namespace, we can directly access the fields by their name
            string username;
            string password;

            username = usernameField.Text;
            password = passwordField.Text;  // we'll need to hash the password eventually

            Database.AddRow(username, password);

            // clear fields
            usernameField.Clear();
            passwordField.Clear();

            // reload the data
            FillDataGird();

        }

        private void loadData_Click(object sender, EventArgs e)
        {
            FillDataGird();
        }
    }
}