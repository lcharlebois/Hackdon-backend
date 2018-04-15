using System;
using System.Collections.Generic;
using System.Text;

namespace Sherweb.HackDon.Models.Entities
{
    public class Post
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string IconUrl { get; set; }
    }
}
