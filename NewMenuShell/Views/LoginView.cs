using System;

namespace NewMenuShell.Views
{
    public class LoginView : BaseView
    {
        public LoginView() : base("Login")
        {
        }

        public override void Display()
        {
            Console.WriteLine("============ Login ============\n" +
                              "                               \n" +
                              "   Username:                   \n" +
                              "   Password:                   \n" +
                              "                               \n" +
                              "===============================");
        }
    }
}