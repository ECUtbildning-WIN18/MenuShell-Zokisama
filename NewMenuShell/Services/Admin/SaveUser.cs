using System;
using System.IO;
using System.Xml.Linq;
using NewMenuShell.Domain;

namespace NewMenuShell.Services.Admin
{
    public class SaveUsers
    {
        public static void SaveUser(User user)
        {
            XDocument doc = null;
            if (File.Exists("Users.xml"))
            {
                doc = XDocument.Load("Users.xml");
            }
            else
            {
                doc = new XDocument();
                doc.Add(new XElement("UserList"));
            }
            var docRoot = doc.Root;
            
            var element = new XElement("User", 
                new XElement("Username", user.Username),
                new XElement("Password", user.Password),
                new XElement("Role", user.Role.ToString()));

            docRoot.Add(element);
            
            doc.Save("Users.xml");
        }
    }
}
