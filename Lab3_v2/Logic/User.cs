using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_v2
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Program> AvailablePrograms { get; set; }

        public User()
        {
            AvailablePrograms = new List<Program>();
        }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
            AvailablePrograms = new List<Program>();
        }

        public bool Authentication(string login, string password)
        {
            if(login == Name && password == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(User user1, User user2)
        {
            if (user1.AvailablePrograms.Capacity > user2.AvailablePrograms.Capacity)
                return true;
            else
                return false;
        }

        public static bool operator !=(User user1, User user2)
        {
            if (user1.AvailablePrograms.Capacity < user2.AvailablePrograms.Capacity)
                return true;
            else
                return false;
        }
    }
}
