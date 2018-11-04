using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NewMenuShell.Domain;

namespace NewMenuShell.DB
{
    public class DataAccess
    {
        public void AddUserToDB(User user)
        {
            using (var context = new MenuShellDbContext())
            {
                var contactExists = context.Users.Any(c => c.Username.Equals(user.Username));
                if (!contactExists)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("User does already exist");
                    Thread.Sleep(1000);
                }
            }
        }

        public void RemoveUserFromDB(User user)
        {
            using (var context = new MenuShellDbContext())
            {
                var deletedUser = context.Users.Where(c => c.Id == user.Id).FirstOrDefault();
                context.Users.Remove(deletedUser);
                context.SaveChanges();
            }
        }

        public List<User> GetUsers()
        {
            using (var context = new MenuShellDbContext())
            {
                return context.Users.ToList();
            }
        }
    }
}