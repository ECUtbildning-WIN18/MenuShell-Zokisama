using System;
using System.Xml.Linq;
using NewMenuShell.Domain;
using NewMenuShell.Services;
using NewMenuShell.Views;

namespace NewMenuShell
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //var loadUsers = new LoadUsers();
            //var saveUser = new SaveUsers();
            var loginView = new LoginView();

            User validatedUser;
            do
            {
                loginView.Display();
                var user = new UserData().CollectUserInput();
            
                validatedUser = new Validation().Authenticate(user);

                if (validatedUser != null)
                {
                    Console.WriteLine("Login Success");
                    break;
                }
                StandardMessages.LoginFail();
            } while (true);

            if (validatedUser.Role == Role.Administrator)
            {
                var adminMainView = new AdminMainView();
                adminMainView.Display();
                
            }
            else if (validatedUser.Role == Role.User)
            {
                var userView = new UserView();
                userView.Display();
            }
        }
    }
}