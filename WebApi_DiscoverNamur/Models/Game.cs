using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class Game
    {
        [Key]
        [Column(Order = 1)]
        public Place VisitedPlaceId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int GameId { get; set; }
        [Required]
        public String Name { get; set; }
    }
}