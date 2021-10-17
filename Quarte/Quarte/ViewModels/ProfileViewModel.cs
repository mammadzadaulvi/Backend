using Quarte.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.ViewModels
{
    public class ProfileViewModel
    {
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 8)]
        public string UserName { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 8)]
        public string FullName { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 8)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 8)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword))]
        public string ConfirmNewPassword { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        //public List<Order> Orders { get; set; }
    }
}
