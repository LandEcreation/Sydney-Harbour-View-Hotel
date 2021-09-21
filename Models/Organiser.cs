using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SydneyHotelFinalWebApp.Models
{
    public class Organiser
    {

        public int OrganiserID { get; set; }
        [DisplayName("OrganiserName")]
        [Required(ErrorMessage = "Enter your Name")]
        public string OrganiserName { get; set; }
        [Phone]
        public string OrganiserPhone { get; set; }
        [EmailAddress]
        public string OrganiserEmail { get; set; }

        [Required]
        public string EventName { get; set; }
        [Required]
        public string PartyNames { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }



        public int TotalMember { get; set; }


        [Range(20, 30, ErrorMessage = "please enter valid range")]
        public virtual ICollection<Registration> Registration { get; set; }




    }
}