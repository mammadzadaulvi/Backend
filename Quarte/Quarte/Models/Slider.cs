using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Models
{
    public class Slider
    {
        public int Id { get; set; }

        public int Order { get; set; }

        [StringLength(maximumLength: 250)]
        public string Icon { get; set; }

        [StringLength(maximumLength: 250)]
        public string IconTitle { get; set; }

        [StringLength(maximumLength: 250)]
        public string Title1 { get; set; }

        [StringLength(maximumLength: 250)]
        public string Title2 { get; set; }

        [StringLength(maximumLength: 250)]
        public string Desc { get; set; }

        [StringLength(maximumLength: 250)]
        public string Image { get; set; }

        [StringLength(maximumLength: 250)]
        public string RedirectUrl { get; set; }

        [StringLength(maximumLength: 250)]
        public string RedirectUrlText { get; set; }


        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
