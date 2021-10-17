using Quarte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.ViewModels
{
    public class ProductViewModel
    {
        public List<Amenity> Amenities { get; set; }
        public List<Category> Categories { get; set; }
        public List<Status> Statuses { get; set; }
    }
}
