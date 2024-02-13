﻿using System.ComponentModel.DataAnnotations;

namespace AuthApi.Models.Authentication.Signup
{
    public class RegisterUser
    {
        [Required(ErrorMessage ="User name is required")]
        public string UserName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
    }
}
