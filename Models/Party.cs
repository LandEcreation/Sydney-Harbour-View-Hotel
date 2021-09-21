using System.Collections.Generic;

namespace SydneyHotelFinalWebApp.Models
{
    public class Party
    {



        public int PartyID { get; set; }
        public string PartyNames { get; set; }

        public virtual ICollection<Registration> Registration { get; set; }




    }
}