using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAss02.Models
{
    internal class OrganizerProfile
    {
        public int Id { get; set; }
        public string Biography { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }


        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }
    }
}
