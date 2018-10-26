using System;

namespace NewMenuShell.Views
{
    public class AdministratorView : BaseView
    {
        public AdministratorView() : base("Administrator")
        {
        }

        public override void Display()
        {
            Console.Clear();
            Console.WriteLine("============ Admin ============\n" +
                              "                               \n" +
                              "   1. Add User                 \n" +
                              "   2. Remove User              \n" +
                              "   3. List Users               \n" +
                              "   4. Search Users             \n" +
                              "                               \n" +
                              "===============================");
        }
    }
}