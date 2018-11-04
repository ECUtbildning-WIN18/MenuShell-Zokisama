using NewMenuShell.Enums;

namespace NewMenuShell.Domain
{
    public class User
    {
        public User()
        {
        }

        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public string UserInfo => $"{Role.ToString()}: {Username}";

        public override string ToString()
        {
            return $"{Role}: {Username}";
        }
    }
}