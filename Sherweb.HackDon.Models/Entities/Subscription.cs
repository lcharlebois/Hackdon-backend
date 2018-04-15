using System;
using System.Collections.Generic;
using System.Text;

namespace Sherweb.HackDon.Models.Entities
{
    public class Subscription
    {
        public Guid Id { get; set; }

        public double Amount { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
