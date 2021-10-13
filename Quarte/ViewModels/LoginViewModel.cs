using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 8)]
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
