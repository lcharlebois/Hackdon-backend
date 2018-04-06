using System;
using System.Collections.Generic;

namespace Sherweb.HackDon.Models.Entities
{
    public class Partner
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Mission { get; set; }

        public List<News> News { get; set; }
    }
}
