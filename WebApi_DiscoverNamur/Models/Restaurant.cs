using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class Restaurant
    {
        [Key]
        public Place VisitedPlaceId { get; set; }
        public int AmountStars { get; set; }
        public string CookingStyle { get; set; }
        public List<double> GammePrix { get; set; }
    }
}