﻿using System.ComponentModel.DataAnnotations;

namespace Application.Models.Identity
{
    public class RegisterRequestDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }

    }
}
