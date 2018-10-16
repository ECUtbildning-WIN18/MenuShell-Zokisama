using System;

namespace NewMenuShell.Views
{
    public class AddUserView : BaseView
    {
        public AddUserView() : base("Add User")
        {
        }

        public override void Display()
        {
            Console.WriteLine("==========  Add User ===========\n" +
                              "                                \n" +
                              "   Username:                    \n" +
                              "   Password:                    \n" +
                              "                                \n" +
                              "================================");
        }
    }
}