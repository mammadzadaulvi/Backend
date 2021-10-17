using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Models
{
    public class About
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 250)]
        public string Icon { get; set; }

        [StringLength(maximumLength: 250)]
        public string Text { get; set; }
    }
}
