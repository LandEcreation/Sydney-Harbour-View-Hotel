using System;
using System.ComponentModel.DataAnnotations;

namespace SydneyHotelFinalWebApp.Models
{
    public class Registration
    {


        public int RegistrationID { get; set; }
        public int PartyID { get; set; }

        public int OrganiserID { get; set; }

        public int AttendeeID { get; set; }

        [Required]
        public DateTime EventStart { get; set; }

        [Required]
        public DateTime EventEnd { get; set; }

        [Range(1, 10, ErrorMessage = "please enter valid range")]
        public int NoofMembers { get; set; }



        public virtual Organiser Organiser { get; set; }

        public virtual Party Party { get; set; }

        public virtual Attendee Attendee { get; set; }








    }
}