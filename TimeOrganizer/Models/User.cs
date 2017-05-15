using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TimeOrganizer.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, StringLength(15), Display(Name ="Nickname")]
        public string Nickname { get; set; }

        [Required, StringLength(20, MinimumLength = 6), Display(Name = "Nickname")]
        public string Password { get; set; }

    }
}