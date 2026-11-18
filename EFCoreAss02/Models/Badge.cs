using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAss02.Models
{
    internal class Badge
    {
        public int Id { get; set; }

        public int BadgeNumber { get; set; }

        public DateTime IssuedDate { get; set; }

        public string Tier { get; set; }


        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}
