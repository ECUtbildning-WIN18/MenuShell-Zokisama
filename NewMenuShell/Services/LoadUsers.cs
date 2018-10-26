using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml.Linq;
using NewMenuShell.Domain;
using NewMenuShell.Services.Admin;

namespace NewMenuShell.Services
{
    public class LoadUsers
    {
        public List<User> LoadUserList()
        {
            XDocument doc;

            if (File.Exists("Users.xml"))
            {
                doc = XDocument.Load("Users.xml");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No users exist...");
                Console.WriteLine("Creating default admin");
                Console.WriteLine("Username: Admin");
                Console.WriteLine("Password: password");
                SaveUsers.SaveUser(new User("Admin", "password", Role.Administrator));
                doc = XDocument.Load("Users.xml");
                Thread.Sleep(2000);
            }

            var userList = new List<User>();
            var root = doc.Root;


            if (root != null)
                foreach (var element in root.Elements())
                {
                    var username = element.Element("Username")?.Value;
                    var password = element.Element("Password")?.Value;
                    var role = element.Element("Role")?.Value;

                    var access = (Role) Enum.Parse(typeof(Role), role);

                    var user = new User(username, password, access);

                    userList.Add(user);
                }

            return userList;
        }
    }
}