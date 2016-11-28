using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class Monument
    {
        [Key]
        public Place VisitedPlaceId { get; set; }
        [Required]
        public DateTime BuildDate { get; set; }

        public string Description { get; set; }
    }
}