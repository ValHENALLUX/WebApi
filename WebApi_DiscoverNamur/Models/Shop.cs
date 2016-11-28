using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class Shop
    {
        [Key]
        public Place IdVisitedPlace { get; set; }
        [Required]
        public int ShopType { get; set; }
    }
}