using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.Models
{
    public class Setting
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string HeaderLogo { get; set; }

        [StringLength(maximumLength: 100)]
        public string FooterLogo { get; set; }

        [StringLength(maximumLength: 100)]
        public string ContactMail { get; set; }
        
        [StringLength(maximumLength: 100)]
        public string SupportMail { get; set; }

        [StringLength(maximumLength: 100)]
        public string PhoneImage { get; set; }

        [StringLength(maximumLength: 100)]
        public string ContactPhone { get; set; }

        [StringLength(maximumLength: 100)]
        public string SupportPhone { get; set; }

        [StringLength(maximumLength: 100)]
        public string AboutImage { get; set; }

        [StringLength(maximumLength: 100)]
        public string AboutTitle { get; set; }

        [StringLength(maximumLength: 300)]
        public string AboutDesc { get; set; }

        [StringLength(maximumLength: 100)]
        public string AboutText { get; set; }

        [StringLength(maximumLength: 100)]
        public string AboutRedirectUrl { get; set; }

        [StringLength(maximumLength: 100)]
        public string AboutRedirectUrlText { get; set; }

        [StringLength(maximumLength: 100)]
        public string Address { get; set; }

        [StringLength(maximumLength: 100)]
        public string FacebookUrl { get; set; }
        
        [StringLength(maximumLength: 100)]
        public string InstagramUrl { get; set; }
        
        [StringLength(maximumLength: 100)]
        public string DribbleUrl { get; set; }
        
        [StringLength(maximumLength: 100)]
        public string TwitterUrl { get; set; }
        
        [StringLength(maximumLength: 100)]
        public string LinkedinUrl { get; set; }




        [StringLength(maximumLength: 100)]
        public string FacebookIcon { get; set; }

        [StringLength(maximumLength: 100)]
        public string InstagramIcon { get; set; }

        [StringLength(maximumLength: 100)]
        public string TwitterIcon { get; set; }
           
        [StringLength(maximumLength: 100)]
        public string DribbleIcon { get; set; }
        
        [StringLength(maximumLength: 100)]
        public string LocationIcon { get; set; }

        [StringLength(maximumLength: 100)]
        public string LinkedinIcon { get; set; }

        [StringLength(maximumLength: 100)]
        public string PhoneIcon { get; set; }




        [NotMapped]
        public IFormFile HeaderImageFile { get; set; }
        [NotMapped]
        public IFormFile FooterImageFile { get; set; }
        [NotMapped]
        public IFormFile AboutImageFile { get; set; }
        [NotMapped]
        public IFormFile VideoImageFile { get; set; }
        [NotMapped]
        public IFormFile AdressImageFile { get; set; }
    }
}
