using System;
using System.Collections.Generic;

namespace Sherweb.HackDon.Models.Entities
{
    public class OSBL
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string OSBLLogoUrl { get; set; }

        public string OSBLName { get; set; }

        public string ExternalOSBLUrl { get; set; }
    }
}