using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_yama.Models
{
    public class Orders
    {
        public int Id { get; set; } //pk
        public int UserId { get; set; } //fk
        public int AddressId { get; set; } //fk
        public int DiscountId { get; set; } //fk
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Status { get; set; }
        public int Amount { get; set; }
    }
}
