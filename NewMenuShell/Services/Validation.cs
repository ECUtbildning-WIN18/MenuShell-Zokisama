using System;
using NewMenuShell.Domain;
using NewMenuShell.Interfaces;

namespace NewMenuShell.Services
{
    public class Validation : IValidation
    {
        public User Authenticate(User user)
        {
            var userList = new LoadUsers().LoadUserList();
            var validatedUser = userList.Find((x => string.Equals(x.Username, user.Username, StringComparison.CurrentCultureIgnoreCase) && x.Password == user.Password));

            return validatedUser;
        }
    }
}