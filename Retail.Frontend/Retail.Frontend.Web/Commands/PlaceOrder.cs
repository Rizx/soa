﻿namespace Retail.Commands
{
    using System.Collections.Generic;
    using Retail.Frontend.Web.Models;

    public class PlaceOrder : IPlaceOrder
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public List<Product> Products { get; set; }
    }
}
