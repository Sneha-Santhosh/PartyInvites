using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvitesPractise.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]

        public string Email { get; set; }
        public string Phone { get; set; }
        public bool NeedsParking { get; set; }
        public bool isVeg { get; set; }
        public bool? WillAttend { get; set; }
        
    }
}
