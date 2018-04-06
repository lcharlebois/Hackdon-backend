using Moment.Services.Models.Entities;
using RawRabbit.Configuration.Exchange;
using RawRabbit.Enrichers.Attributes;
using System;

namespace Moment.Services.Daemon
{
    [Queue(Name = "Deal.odata.event", Durable = true)]
    [Exchange(Name = "Deal", Type = ExchangeType.Topic)]
    [Routing(RoutingKey = "Deal.odata.event", AutoAck = true, PrefetchCount = 50)]
    public class ProfileMessage : Deal
    {
        public Guid GlobalRequestId { get; set; }
    }
}
