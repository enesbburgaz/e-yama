using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_yama.Models
{
    public class Tags
    {
        public int Id { get; set; } //pk
        public int ProductId { get; set; } //fk
        public string Tag { get; set; }
    }
}
