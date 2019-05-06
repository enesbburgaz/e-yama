using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_yama.Models
{
    public class CartItem
    {
        public int Id { get; set; } 
        public EYUser EYUser { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public bool SavedForLater { get; set; }
        public int Quantity { get; set; }
        public DateTime TimeAdded { get; set; }
    }
}
