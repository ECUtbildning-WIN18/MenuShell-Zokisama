using System.Data.Entity;
using NewMenuShell.Domain;

namespace NewMenuShell.DB
{
    public class MenuShellDbContext : DbContext
    {
        public MenuShellDbContext() : base("MenushellDbContext")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}