﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_yama.Models
{
    public class Order
    {
        public int Id { get; set; }
        public EYUser EYUser { get; set; }
        public Address Address { get; set; }
        public Discount Discount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Status { get; set; }
        public int Amount { get; set; }
    }
}
