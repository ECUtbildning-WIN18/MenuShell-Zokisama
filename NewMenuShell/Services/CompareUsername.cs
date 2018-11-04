using NewMenuShell.DB;
using NewMenuShell.Domain;

namespace NewMenuShell.Services
{
    public static class CompareUsername
    {
        public static User GetUser(string username)
        {
            var users = new DataAccess().GetUsers();

            var validUser = users.Find(x => x.Username == username);
            return validUser;
        }
    }
}