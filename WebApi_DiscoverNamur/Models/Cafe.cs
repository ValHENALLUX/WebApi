using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class Cafe
    {
        [Key]
        public Place VisitedPlaceId { get; set; }

        public string Specialty { get; set; }

        public List<DateTime> HappyHour { get; set; }
    }
}