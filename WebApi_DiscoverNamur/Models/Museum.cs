using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class Museum
    {
        [Key]
        public Place VisitedPlaceId { get; set; }

        public string Theme { get; set; }

        public DateTime OpeningDate { get; set; }

        public bool PaidEntry { get; set; }

        public DateTime VisitDuration { get; set; }

        public bool InvalidPersonEntry { get; set; }
    }
}