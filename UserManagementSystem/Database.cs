

using Microsoft.Data.Sqlite;
using System.Data;

namespace UserManagementSystem
{
    class Database
    {

        private const string CONNECTION_DATA_SOURCE = "DataSource=database.db";

        public static void AddRow(string username, string password)
        {
            SqliteConnection connection = new SqliteConnection(CONNECTION_DATA_SOURCE);

            string query = @"
                            INSERT INTO User (FIRST_NAME, LAST_NAME)
                            VALUES (@username, @password);
                            ";

            SqliteCommand command = new SqliteCommand(query, connection);

            SqliteParameter[] @params = {
                Database.CreateSqliteParam("@username", 3, username),
                Database.CreateSqliteParam("@password", 3, password)
                    };

            command.Parameters.AddRange(@params);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void SetUp()
        {  
                try
                {
                    // create the table with default schema
                    SqliteConnection connection = new SqliteConnection(CONNECTION_DATA_SOURCE);
                    string commandText = @"
                                      CREATE TABLE IF NOT EXISTS User (ID integer primary key autoincrement,
                                                         USERNAME text not null,
                                                         PASSWORD text not null);
                                      INSERT INTO User (USERNAME, PASSWORD)
                                      VALUES ('john doe','123');
                                      ";

                    SqliteCommand command = new SqliteCommand(commandText, connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch(SqliteException e)
                {
                    Console.WriteLine("SqliteException");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("UnhandledException");
                    Console.WriteLine(e.Message);
                }
        }

        public static SqliteParameter CreateSqliteParam(string variable, int type, string value)
        {
            SqliteParameter param = new SqliteParameter(variable, type);
            param.Value = value;

            return param;
        }
    }
}
