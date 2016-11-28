using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApi_DiscoverNamur.Models
{
    public class Place
    {
        [Key]
        public int VisitedPlaceId { get; set; }
        [Required]
        public string Name { get; set; }

        public string Category { get; set; }
        
        private string phoneNumber;

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                if (isPhoneNumberValid(value))
                {
                    phoneNumber = value;
                }
            }
        }

        public DateTime OpeningHour { get; set; }

        public string Town { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public long Coo_Latitude { get; set; }

        public long Coo_Longitude { get; set; }

        private Boolean isPhoneNumberValid(string value)
        {
            Match match = Regex.Match(value, "04([7-9][0-9])\/([0-9][0-9])\.([0-9][0-9])\.([0-9][0-9])");
            return match.Success;
        }

    }
}