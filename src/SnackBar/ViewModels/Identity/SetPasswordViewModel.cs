﻿using System.ComponentModel.DataAnnotations;

namespace SnackBar.ViewModels
{
    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessageResourceName = "ErrorPassword", ErrorMessageResourceType = typeof(Resx.Resource), MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassword", ResourceType = typeof(Resx.Resource))]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resx.Resource))]
        [Compare("NewPassword", ErrorMessageResourceName = "ErrorComparePassword", ErrorMessageResourceType = typeof(Resx.Resource))]
        public string ConfirmPassword { get; set; }
    }
}