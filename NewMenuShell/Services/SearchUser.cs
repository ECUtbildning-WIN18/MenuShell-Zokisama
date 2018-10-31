using System;
using System.Linq;
using NewMenuShell.DB;
using NewMenuShell.Domain;

namespace NewMenuShell.Services
{
    public class SearchUser
    {
        public static void SearchInUserList(string userToSearch)
        {
            var users = new DataAccess().GetUsers();

            var selectedUser = users.Where(x => x.Username.ToLower().Contains(userToSearch.ToLower()));

            Console.WriteLine($"These users contains {userToSearch}");
            foreach (var user in selectedUser)
                {
                    Console.WriteLine(user.Username);
                }
        }
    }
}