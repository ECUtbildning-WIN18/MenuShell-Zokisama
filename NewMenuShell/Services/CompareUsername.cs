using NewMenuShell.Domain;

namespace NewMenuShell.Services
{
    public class CompareUsername
    {
        public static User GetUser(string username)
        {
            var listOfUsers = new LoadUsers();
            var users = listOfUsers.LoadUserList();

            var validUser = users.Find(x => x.Username == username);
            return validUser;
        }
    }
}