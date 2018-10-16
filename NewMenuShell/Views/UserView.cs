using System;

namespace NewMenuShell.Views
{
    public class UserView : BaseView
    {
        public UserView() : base("User")
        {
        }

        public override void Display()
        {
            Console.WriteLine("==========  User View ===========\n" +
                              "                                \n" +
                              "   Nothing fun here             \n" +
                              "   Maybe soon!!                 \n" +
                              "                                \n" +
                              "================================");
        }
    }
}