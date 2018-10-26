using System;

namespace NewMenuShell.Views
{
    public class SearchUserView : BaseView
    {
        public SearchUserView() : base("Search User")
        {
        }

        public override void Display()
        {
            Console.WriteLine("============ Search User ============\n" +
                              "                               \n" +
                              "   Which user are you looking for?\n" +
                              "   Enter username: \n");
        }
    }
}