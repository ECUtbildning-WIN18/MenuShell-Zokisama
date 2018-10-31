using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using NewMenuShell.Domain;
using NewMenuShell.Enums;
using NewMenuShell.Services;

namespace NewMenuShell.DB
{
    public class DataAccess
    {
        public void AddUserToDB(User user)
        {
            using (var connection = new SqlConnection(Helper.CnnVal("UserDB")))
            {
                connection.Open();
                var queryString = $"INSERT INTO UserTbl VALUES ('{user.Username}', '{user.Password}', '{RoleCheckToString(user)}')";
                var command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();
            }
        }

        public void RemoveUserFromDB(User user)
        {
            using (var connection = new SqlConnection(Helper.CnnVal("UserDB")))
            {
                connection.Open();
                var queryString = $"DELETE FROM UserTbl WHERE Username = ('{user.Username}')";
                var command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();
            }
        }
        
        public List<User> GetUsers()
        {
            var users = new List<User>();
            using (var connection = new SqlConnection(Helper.CnnVal("UserDB")))
            {
                connection.Open();
                
                var queryString = "SELECT * FROM UserTbl"; //WHERE Username = '{username}'
                var command = new SqlCommand(queryString, connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        users.Add(new User(reader["Username"].ToString(), reader["Password"].ToString(), RoleCheckToEnum(reader)));
                    }
                }
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