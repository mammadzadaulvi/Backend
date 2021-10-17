using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.ViewModels
{
    public class RegisterViewModel
    {
        [StringLength(maximumLength: 50, MinimumLength = 10)]
        public string UserName { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 10)]
        public string FullName { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 10)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
