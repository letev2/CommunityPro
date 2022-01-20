﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Entities
{
    public class OrderProduct : BaseEntity
    {
        public Guid OrderId { get; set; }

        public Order Order { get; set; }

        public Guid ProductId { get; set; } 

        public Product Product { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }
    }
}
