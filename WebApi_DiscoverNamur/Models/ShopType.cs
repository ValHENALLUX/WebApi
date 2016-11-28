using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class ShopType
    {
        [Key]
        public int IdShopTyp { get; set; }
        [Required]
        public int ShopTypeId { get; set; }
    }
}