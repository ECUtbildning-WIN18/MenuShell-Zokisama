using System;
using System.Xml.Linq;
using NewMenuShell.Domain;

namespace NewMenuShell.Services.Admin
{
    public class SaveUsers
    {
        public static void SaveUser(User user)
        {
            var doc = XDocument.Load("Users.xml");
            Console.WriteLine(doc);
            var docRoot = doc.Root;
            
            var element = new XElement("User", 
                new XElement("Username", user.Username),
                new XElement("Password", user.Password),
                new XElement("Role", user.Role.ToString()));

            docRoot.Add(element);
            Console.WriteLine(docRoot);
            doc.Save("Users.xml");
        }
    }
}