using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class Visit
    {
        [Key]
        [Column(Order = 1)]
        public int VisitId { get; set; }
        [Key]
        [Column(Order = 2)]
        public Course CourseId { get; set; }
        [Key]
        [Column(Order = 3)]
        public int CoursePlaceNumber { get; set; }

    }
}