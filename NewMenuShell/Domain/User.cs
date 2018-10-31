using NewMenuShell.Enums;
using NewMenuShell.Services;

namespace NewMenuShell.Domain
{
    public class User
    {
        public string Username { get; }
        public string Password { get; }
        public Role Role { get; }
        
        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public string UserInfo => $"{Role.ToString()}: {Username}";

        public override string ToString()
        {
            return $"{Role}: {Username}";
        }
    }
}