using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        [Required]
        public string Description { get; set; }

        public string Answer { get; set; }
        [Required]
        public string Type { get; set; }

        public int AmountBonusPoints { get; set; }

        public Place VisitedPlaceId { get; set; }

        public int Ind_VisitedPlaceId { get; set; }
    }
}