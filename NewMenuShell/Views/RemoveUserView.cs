using System;

namespace NewMenuShell.Views
{
    public class RemoveUserView : BaseView
    {
        public RemoveUserView() : base("Remove User")
        {
        }

        public override void Display()
        {
            Console.WriteLine("============ Remove User ============\n" +
                              "                               \n" +
                              "   Which user do you wish to delete?\n" +
                              "   Enter username: \n");
        }
    }
}