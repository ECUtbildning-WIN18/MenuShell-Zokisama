using System;
using System.Data.SqlClient;

namespace NewMenuShell.DB
{
    public class CreateDBTable
    {
        public void InitialData()
        {
            using (var connection = new SqlConnection(Helper.CnnVal("UserDB")))
            {
                connection.Open();
                var queryStringTable =
                    "IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U')) " +
                    "BEGIN " +
                    "CREATE TABLE [User] ( " +
                    "ID INT IDENTITY(1,1) PRIMARY KEY, " +
                    "Username VARCHAR(100), " +
                    "Password NVARCHAR(100), " +
                    "Role     VARCHAR(50) " +
                    ") " +
                    // Creating USERS IN TABLE 
                    "INSERT INTO [User] " +
                    "VALUES " +
                    "('Zoki', 'pw98', 'Administrator'), " +
                    "('username1', 'password1', 'User'), " +
                    "('user2', 'password2', 'User'), " +
                    "('user3', 'password3', 'User') " +
                    "END";
                var command = new SqlCommand(queryStringTable, connection);
                command.ExecuteNonQuery();

            }
        }
    }
}