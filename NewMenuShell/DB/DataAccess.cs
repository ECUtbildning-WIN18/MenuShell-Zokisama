using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using NewMenuShell.Domain;
using NewMenuShell.Enums;

namespace NewMenuShell.DB
{
    public class DataAccess
    {
        public void AddUserToDB(User user)
        {
            using (var connection = new SqlConnection(Helper.CnnVal("UserDB")))
            {
                connection.Open();
                var queryString = $"INSERT INTO [User] VALUES ('{user.Username}', '{user.Password}', '{RoleCheckToString(user)}')";
                var command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void RemoveUserFromDB(User user)
        {
            using (var connection = new SqlConnection(Helper.CnnVal("UserDB")))
            {
                connection.Open();
                var queryString = $"DELETE FROM [User] WHERE Username = ('{user.Username}')";
                var command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        
        public List<User> GetUsers()
        {
            var users = new List<User>();
            using (var connection = new SqlConnection(Helper.CnnVal("UserDB")))
            {
                connection.Open();
                
                var queryString = "SELECT * FROM [User]"; //WHERE Username = '{username}'
                var command = new SqlCommand(queryString, connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        users.Add(new User(reader["Username"].ToString(), reader["Password"].ToString(), RoleCheckToEnum(reader)));
                    }
                }
                connection.Close();
            }
            return users;
        }

        private static Role RoleCheckToEnum(IDataRecord reader)
        {
            return reader["Role"].ToString() == "Administrator" ? Role.Administrator : Role.User;
        }
        
        private static string RoleCheckToString(User user)
        {
            return user.Role == Role.Administrator ? "Administrator" : "User";
        }
    }
}