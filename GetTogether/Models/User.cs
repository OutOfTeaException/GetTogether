using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTogether.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public DateTime CreatedAt { get; private set; }

        private User() { }

        public User(string name, string email)
        {
            Name = name;
            EMail = email;

            CreatedAt = DateTime.Now;
        }
    }
}
