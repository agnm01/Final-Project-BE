using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FE_FinalProject.Models
{
    public class Profile
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public int Age { get; set; }

        public DateTime Birthdate { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Degree { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Website { get; set; }

        public List<string> Interests { get; set; }

        public virtual List<Skill> Skills { get; set; }

        public virtual List<School> Schools { get; set; }

        public virtual List<Workplace> Workplaces { get; set; }

        public virtual List<Tool> Tools { get; set; }

        public string Picture { get; set; }
    }
}
