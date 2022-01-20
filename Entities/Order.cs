﻿
using CommunityProApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityProApp.Entities
{
    public class Order : BaseEntity
    {
        public string OrderReference { get; set; }

        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }

        public OrderStatus Status { get; set; }

        public string DeliveryAddress { get; set; }

        public decimal TotalPrice { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}
