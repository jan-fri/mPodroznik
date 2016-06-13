﻿using System.ComponentModel.DataAnnotations;

namespace mPodroznik.Models.User
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "User Name: ")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }
        public string PasswordSalt { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address: ")]
        public string Email { get; set; }
    }
}