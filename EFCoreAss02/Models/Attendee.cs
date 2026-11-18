using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreAss02.Models
{
    internal class Attendee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FuulName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }


        [Required]
        [MaxLength(100)]
        public string City { get; set; }


        [Required]
        [MaxLength(150)]
        public string Street { get; set; }


        [Required]
        [MaxLength(100)]
        public string Country { get; set; }


        [Column("ZipCode")]
        [Required]
        [MaxLength(20)]
        public string PostalCode { get; set; }

        [NotMapped]
        public string FullAddress
        {
            get { return $"{City} , {Street} , {Country} , {PostalCode}"; }

        }


        public Badge? Badge { get; set; }

    }
}
