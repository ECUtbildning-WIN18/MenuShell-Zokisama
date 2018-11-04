using System;
using NewMenuShell.DB;
using NewMenuShell.Domain;
using NewMenuShell.Enums;
using NewMenuShell.Services;
using NewMenuShell.Services.Admin;

namespace NewMenuShell.Views
{
    public class AdminMainView : BaseView
    {
        public AdminMainView() : base("Administrator")
        {
        }

        public override void Display()
        {
            var adminView = new AdministratorView();
            var dataAccess = new DataAccess();

            do
            {
                adminView.Display();
                var ckey = Console.ReadKey(true);
                if (ckey.Key == ConsoleKey.D1)
                {
                    var addUserView = new AddUserView();
                    addUserView.Display();
                    var userToSave = new UserData().CollectUserInput();
                    dataAccess.AddUserToDB(userToSave);
                }
                else if (ckey.Key == ConsoleKey.D2)
                {
                    var removeUserView = new RemoveUserView();
                    removeUserView.Display();
                    ListUsers.PrintUsers();
                    var userInput = UserData.UserToRemove();
                    var toBeRemovedUser = CompareUsername.GetUser(userInput);
                    if (toBeRemovedUser != null && toBeRemovedUser.Role != Role.Administrator)
                        dataAccess.RemoveUserFromDB(toBeRemovedUser);
                    else
                        StandardMessages.RedMessage("User does not exist \n or User can't be deleted.");
                }
                else if (ckey.Key == ConsoleKey.D3)
                {
                    Console.Clear();
                    ListUsers.PrintUsers();
                    Console.WriteLine("press any key to go back");
                    Console.ReadKey();
                }
                else if (ckey.Key == ConsoleKey.D4)
                {
                    var searchUserView = new SearchUserView();
                    searchUserView.Display();
                    var userInput = UserData.UserToRemove();
                    SearchUser.SearchInUserList(userInput);
                    Console.ReadKey();
                }
                else if (ckey.Key == ConsoleKey.D5)
                {
                    Console.WriteLine("Are you sure that you want to loggout?");
                    Console.WriteLine("    (Y)es / (N)o");
                    ckey = Console.ReadKey();
                    if (ckey.Key == ConsoleKey.Y) return;
                }
                else
                {
                    StandardMessages.RedMessage("Invalid input");
                }
            } while (true);
        }
    }
}