using System;
using System.Collections.Generic;

namespace Sherweb.HackDon.Models.Entities
{
    public class SubCategory
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string IconUrl { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }
}