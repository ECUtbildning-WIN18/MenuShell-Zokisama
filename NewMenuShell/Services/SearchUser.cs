using NewMenuShell.Domain;

namespace NewMenuShell.Services
{
    public class SearchUser
    {
        public static User SearchInUserList(string userToSearch)
        {
            var loadUsers = new LoadUsers();
            var listOfUsers = loadUsers.LoadUserList();
            User selectedUser;
            selectedUser = listOfUsers.Find( x => x.Username.Contains(userToSearch));

            return selectedUser;
        }
    }
}