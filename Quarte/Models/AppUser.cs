﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Models
{
    public class AppUser:IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        public bool IsAdmin { get; set; }
    }
}
