using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class History
    {
        [Key]
        [Column(Order=1)]
        public User UserId { get; set; }
        [Key]
        [Column(Order = 2)]
        public DateTime CourseDate { get; set; }
        [Required]
        public DateTime CourseHour { get; set; }
        [Required]
        public int WonPoints { get; set; }
        [Required]
        public Course CourseId { get; set; }
        
    }
}