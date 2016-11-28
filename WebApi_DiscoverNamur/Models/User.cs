using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        
        public string Name { get; set; }
        
        public string Surname { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        private string eMail;
        
        public string EMail
        {
            get
            {
                return eMail;
            }

            set
            {
                if (isEmailValid(value))
                {
                    eMail = value;
                }
            }
        }
        [Required]
        public string PassWord { get; set; }

        private Boolean isEmailValid(string value)
        {
            Match match = Regex.Match(value, "([A-Za-z0-9]+)\@([A-Za-z0-9]+)\.([A-Za-z0-9]+)");
            return match.Success;
        }
    }
}