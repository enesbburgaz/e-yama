using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_yama.Models
{
    public class OrderItem
    {
        public int Id { get; set; } //pk
        public int OrderId { get; set; } //fk
        public int ProductDetails { get; set; } //fk
        public int Quantity { get; set; }
    }
}
