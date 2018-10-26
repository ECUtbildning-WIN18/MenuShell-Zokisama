using System.Xml.Linq;
using NewMenuShell.Domain;

namespace NewMenuShell.Services
{
    public class DeleteUser
    {
        public void RemoveUser(User user)
        {
            var doc = XDocument.Load("Users.xml");
            var docRoot = doc.Root;

            foreach (var element in docRoot.Elements())
                if (user.Username == element.Element("Username")?.Value)
                    element.Element("Username").Parent.Remove();
            doc.Save("Users.xml");
        }
    }
}