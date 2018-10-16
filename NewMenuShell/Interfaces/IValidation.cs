using NewMenuShell.Domain;

namespace NewMenuShell.Interfaces
{
    public interface IValidation
    {
        User Authenticate(User user);
    }
}