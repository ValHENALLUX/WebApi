using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class GenericQuestion
    {
        [Key]
        [Column(Order = 1)]
        public Course CourseId { get; set; }
        [Key]
        [Column(Order = 2)]
        public Question QuestionId { get; set; }
    }
}