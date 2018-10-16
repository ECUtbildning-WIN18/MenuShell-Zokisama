using System;
using NewMenuShell.Domain;
using NewMenuShell.Services;
using NewMenuShell.Services.Admin;

namespace NewMenuShell.Views
{
    public class AdminMainView :BaseView
    {
        public AdminMainView() : base("Administrator")
        {
        }

        public override void Display()
        {
            var adminView = new AdministratorView();
            var saveUser = new SaveUsers();
            
            do
            {
                adminView.Display();
                var ckey = Console.ReadKey(true);
                switch (ckey.Key)
                {
                    case ConsoleKey.D1:
                    {
                        var addUserView = new AddUserView();
                        addUserView.Display(); 
                        var userToSave = new UserData().CollectUserInput();
                        SaveUsers.SaveUser(userToSave);
                        break;
                    }
                    case ConsoleKey.D2:
                    {
                        var removeUserView = new RemoveUserView();
                        removeUserView.Display();
                        ListUsers.PrintUsers();
                        var userInput = UserData.UserToRemove();
                        var toBeRemovedUser = CompareUsername.GetUser(userInput);
                        if (toBeRemovedUser != null && toBeRemovedUser.Role != Role.Administrator)
                        {
                            var deleteUser = new DeleteUser();
                            deleteUser.RemoveUser(toBeRemovedUser);
                        }
                        else
                        {
                            StandardMessages.RedMessage("User does not exist \n or User can't be deleted.");
                        }
                        break;
                    }
                    case ConsoleKey.D3:
                        Console.Clear();
                        ListUsers.PrintUsers();
                        Console.WriteLine("press any key to go back");
                        Console.ReadKey();
                        break;
                    default:
                        StandardMessages.RedMessage("Invalid input");
                        break;
                }
            } while (true);
        }
    }
}