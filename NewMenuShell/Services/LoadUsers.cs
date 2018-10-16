using System;
using System.Collections.Generic;
using System.Xml.Linq;
using NewMenuShell.Domain;

namespace NewMenuShell.Services
{
    public class LoadUsers
    {
        public List<User> LoadUserList()
        {
            var userList = new List<User>();
            var doc = XDocument.Load("Users.xml");
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