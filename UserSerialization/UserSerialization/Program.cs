using System;
using System.Collections.Generic;
using System.Text.Json;

namespace UserSerialization
{
    class Program
    {
        static List<User> users = new List<User>();
        static void Main(string[] args)
        {
            
            User s = new User(1, "ss", Enum.NotActive);
            User s1 = new User(2, "ss", Enum.NotActive);
            users.Add(s);
            users.Add(s1);


        }

        public static void CreateUser(User _s) {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(_s, options);

            Console.WriteLine(jsonString);
        }

        public static void GetUsersByName(string _name) {
            foreach (User u in users)
            {
                if (_name == u.Name)
                {
                    Console.WriteLine(u.ToString());
                }
            }
        }

        public static void GetUser(int _id)
        {
            foreach (User u in users)
            {
                if (_id == u.ID)
                {
                    Console.WriteLine(u.ToString());
                }
            }
        }

        
    }

}
