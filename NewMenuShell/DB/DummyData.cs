using System.Linq;
using NewMenuShell.Domain;
using NewMenuShell.Enums;

namespace NewMenuShell.DB
{
    public static class DummyData
    {
        public static void InitialData()
        {
            var dummyUser = new User("Admin", "secret", Role.Administrator);

            using (var context = new MenuShellDbContext())
            {
                var userExists = context.Users.Any(c => c.Username.Equals(dummyUser.Username));

                if (userExists) return;
                context.Users.Add(dummyUser);
                context.SaveChanges();
            }
        }
    }
}