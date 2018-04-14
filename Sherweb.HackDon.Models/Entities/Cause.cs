using System;
using System.Collections.Generic;

namespace Sherweb.HackDon.Models.Entities
{
    public class Cause
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ProjectImageUrl { get; set; }

        public string ExternalProjectUrl { get; set; }

        public Guid SubCategoryId { get; set; }

        public SubCategory SubCategory { get; set; }

        public Guid OSBLId { get; set; }

        public OSBL OSBL { get; set; }
    }
}