﻿namespace Retail.Shipping.Host.Messages
{
    using System.Collections.Generic;
    using NServiceBus;
    using Retail.Shipping.Host.Models;

    public class OrderPlaced : IEvent
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public List<Product> Products { get; set; }
    }
}
