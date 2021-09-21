using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SydneyHotelFinalWebApp.Models
{
    public class Attendee
    {


        public int AttendeeID { get; set; }

        [DisplayName("CustomerName")]
        [Required(ErrorMessage = "Enter your Name")]

        public string CustomerName { get; set; }

        [Phone]
        public string CustomerPhone { get; set; }
        [EmailAddress]
        public string CustomerEmail { get; set; }

        public string CustomerAddress { get; set; }
        [Required(ErrorMessage = "please enter valid postcode")]
        public string Postcode { get; set; }



        public virtual ICollection<Registration> Registration { get; set; }


    }
}