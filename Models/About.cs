using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FE_FinalProject.Models
{
    public class About
    {
        public About(string id, DateTime birthday, int age, string website, string degree, string phone, string email, string city, string freelance)
        {
            this.Id = id;
            this.Birthday = birthday;
            this.Age = age;
            this.Website = website;
            this.Degree = degree;
            this.Phone = phone;
            this.Email = email;
            this.City = city;
            this.Freelance = freelance;
        }

        public About(DateTime birthday, int age, string website, string degree, string phone, string email, string city, string freelance)
        {
            this.Birthday = birthday;
            this.Age = age;
            this.Website = website;
            this.Degree = degree;
            this.Phone = phone;
            this.Email = email;
            this.City = city;
            this.Freelance = freelance;
        }

        public About()
        {
        }

        public string Id { get; set; }

        public DateTime Birthday { get; set; }

        public int Age { get; set; }

        public string Website { get; set; }

        public string Degree { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public string Freelance { get; set; }
    }
}
