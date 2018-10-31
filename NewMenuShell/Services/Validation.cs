using System;
using NewMenuShell.DB;
using NewMenuShell.Domain;
using NewMenuShell.Interfaces;

namespace NewMenuShell.Services
{
    public class Validation : IValidation
    {
        public User Authenticate(User user)
        {
            var users = new DataAccess().GetUsers();

            var validatedUser = users.Find(x =>
                string.Equals(x.Username, user.Username, StringComparison.CurrentCultureIgnoreCase) &&
                x.Password == user.Password);

            return validatedUser;
        }
    }
}