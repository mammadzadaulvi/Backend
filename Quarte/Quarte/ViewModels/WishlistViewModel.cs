using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quarte.ViewModels
{
    public class WishlistViewModel
    {
        public string Name { get; set; }

        public string Image { get; set; }
        public int Count { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
    }
}
