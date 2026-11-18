using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAss02.Models
{
    [Table("EventOrganizers")]
    internal class Organizer
    {
        public  int  Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string? CompanyName { get; set; }



        public OrganizerProfile OrganizerProfile { get; set; }

        public ICollection<Event> Events{ get; set; } = new List<Event>();

    }
}
