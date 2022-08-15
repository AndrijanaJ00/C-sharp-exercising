using System;
using System.Collections.Generic;
using System.Text.Json;

namespace UserSerialization
{
    enum Enum { 
        Active,
        NotActive
    }
    class User
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public Enum Active { get; set; }

        public User(int iD, string name, Enum active)
        {
            ID = iD;
            Name = name;
            Active = active;
        }

        public override string ToString()
        {
            return "" + ID + " " + Name + " " + Active;
        }
    }
}
