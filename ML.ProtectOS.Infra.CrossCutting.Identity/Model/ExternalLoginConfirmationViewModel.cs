﻿using System.ComponentModel.DataAnnotations;

namespace ML.ProtectOS.Infra.CrossCutting.Identity.Model
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}