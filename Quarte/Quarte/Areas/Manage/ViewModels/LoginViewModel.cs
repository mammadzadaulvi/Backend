using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Areas.ViewModels
{
    public class LoginViewModel
    {
        [StringLength(maximumLength: 50, MinimumLength = 8, ErrorMessage = "Min 6, Max 50")]
        public string UserName { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 8, ErrorMessage = "Min 6, Max 50")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
