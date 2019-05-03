using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_yama.Models
{
    public class ProductDetails
    {
        public int Id { get; set; } //pk
        public int ProductId { get; set; } //fk
        public string Size { get; set; }
        public string Color { get; set; }

    }
}
