using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Fitness
{
    public class UserAdministration
    {
        List<User> myUsers = new List<User>();

        public void AddUser(User user) 
        {
            myUsers.Add(user);
        }

        public void DeleteUser(User user) 
        {
            myUsers.Remove(user);
        }

        public void ChangePassword() 
        {
        
        }

    }
}
