using System;
using System.Linq;
using NewMenuShell.Domain;

namespace NewMenuShell.Services
{
    public class SearchUser
    {
        public static void SearchInUserList(string userToSearch)
        {
            var loadUsers = new LoadUsers();
            var listOfUsers = loadUsers.LoadUserList();

            var selectedUser = listOfUsers.Where(x => x.Username.Contains(userToSearch));

            Console.WriteLine($"These users contains {userToSearch}");
            foreach (var user in selectedUser)
                {
                    Console.WriteLine(user.Username);
                }
        }
    }
}