using System.ComponentModel.DataAnnotations;

namespace SydneyHotelFinalWebApp.Models
{
    public class GroupInfo
    {



        public int GroupInfoID { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public int StudentID { get; set; }

        [Required]
        public string Contribution { get; set; }


        [Required]
        public string TutotName { get; set; }







    }
}