using NewMenuShell.DB;
using NewMenuShell.Domain;
using NewMenuShell.Enums;
using NewMenuShell.Services;
using NewMenuShell.Views;

namespace NewMenuShell
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyData.InitialData();

            User validatedUser;
            do
            {
                var loginView = new LoginView();

                loginView.Display();
                var user = new UserData().CollectUserInput();

                validatedUser = new Validation().Authenticate(user);

                if (validatedUser != null) break;
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