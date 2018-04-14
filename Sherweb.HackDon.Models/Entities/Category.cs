using System;

namespace Sherweb.HackDon.Models.Entities
{
    public class Category
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string IconUrl { get; set; }
    }
}
