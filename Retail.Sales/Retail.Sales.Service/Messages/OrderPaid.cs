﻿namespace Retail.Sales.Service.Messages
{
    using NServiceBus;

    public class OrderPaid : IEvent
    {
        public string OrderId { get; set; }
    }
}