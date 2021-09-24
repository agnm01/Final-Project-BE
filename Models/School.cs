using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FE_FinalProject.Models
{
    public class School
    {
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Specialization { get; set; }

        public string Description { get; set; }

        public string ProfileId { get; set; }

        [JsonIgnore]
        public Profile Profile { get; set; }
    }
}
