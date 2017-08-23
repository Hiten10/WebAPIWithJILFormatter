using System;
using System.ComponentModel.DataAnnotations;

namespace WebAPIWithJILFormatter.Models
{
    public class Student
    {
        [Required]
        public int StudentID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public char Gender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string FatherName { get; set; }

    }
}