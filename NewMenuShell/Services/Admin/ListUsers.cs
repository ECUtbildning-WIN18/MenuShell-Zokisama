using System;

namespace NewMenuShell.Services.Admin
{
    public class ListUsers
    {
        public static void PrintUsers()
        {
            var loadUsers = new LoadUsers();
            var listOfUsers = loadUsers.LoadUserList();

            foreach (var user in listOfUsers) Console.WriteLine($"   {user}");
        }
    }
}