using System;
using NewMenuShell.DB;
using NewMenuShell.Domain;

namespace NewMenuShell.Services.Admin
{
    public static class ListUsers
    {
        public static void PrintUsers()
        {
            var users = new DataAccess().GetUsers();

            foreach (var user in users) Console.WriteLine($"{user.UserInfo}");
        }
    }
}