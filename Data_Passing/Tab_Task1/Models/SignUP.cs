using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Tab_Task1.Models
{
    public class SignUP
    {
        //public Student(string Name, string Id)
        //{
        //    this.Name = Name;
        //    this.Id = Id;
        //}
        [Required]
        public string Name { get; set; }
        [Required]

        public string Id { get; set; }
        [Required]

        public string Gender { get; set; }
        [Required]

        public string Profession { get; set; }
        [Required]

        public string[] Hobbies { get; set; }
        [Required]

        public DateTime Dob { get; set; }

    }
}