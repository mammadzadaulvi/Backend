using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Models
{
    public class Team
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [StringLength(maximumLength: 50)]
        public string FullName { get; set; }

        [StringLength(maximumLength: 250)]
        public string Desc { get; set; }

        [StringLength(maximumLength: 250)]
        public string FacebookIcon { get; set; }
        [StringLength(maximumLength: 250)]

        public string TwitterIcon { get; set; }
        [StringLength(maximumLength: 250)]

        public string LinkedinIcon { get; set; }

        public List<Product> Products { get; set; }
    }
}
