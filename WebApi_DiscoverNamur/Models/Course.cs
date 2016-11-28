using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string Category { get; set; }
        
        public double length { get; set; }

        public DateTime ApproximativeDuration { get; set; }

        [Required]
        public int AmountPoints { get; set; }

    }
}