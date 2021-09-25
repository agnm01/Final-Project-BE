using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_FinalProject.Models
{
    public class User
    {
        public User(string id, string name, string role)
        {
            this.Id = id;
            this.Name = name;
            this.Role = role;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }
    }
}
