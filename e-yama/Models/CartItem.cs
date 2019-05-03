using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_yama.Models
{
    public class CartItem
    {
        public int Id { get; set; } //pk
        public string UserId { get; set; } //fk
        public int ProductDetails { get; set; } //fk
        public bool SavedForLater { get; set; }
        public int Quantity { get; set; }
        public DateTime TimeAdded { get; set; }
    }
}
