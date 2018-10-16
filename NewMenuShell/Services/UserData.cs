using System;
using NewMenuShell.Domain;

namespace NewMenuShell.Services
{
    public class UserData
    {
        public User CollectUserInput()
        {
            Console.SetCursorPosition(13, 2);
            var username = Console.ReadLine();
            Console.SetCursorPosition(13, 3);
            var password = Console.ReadLine();
            
            return new User(username, password, Role.User);
        }

        public static string UserToRemove()
        {
            Console.SetCursorPosition(19, 3);
            return Console.ReadLine();
        }
    }
}