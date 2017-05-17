using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TimeOrganizer.Models
{
    public class Activity
    {
        public int Id { get; set; }

        [Required, StringLength(23, MinimumLength = 4), Display(Name = "Activity Name")]
        public string ActivityName { get; set; }
        
        [StringLength(120), Display(Name = "Activity Description")]
        public string ActivityDescription { get; set; }

        [Required, Range(0, int.MaxValue), Display(Name = "Time")]
        public int ActivityTime { get; set; } //activity time in mins

        //Forgeign Key
        public int UserId { get; set; }
        //Nav propety
        public User User { get; set; }
    }
}