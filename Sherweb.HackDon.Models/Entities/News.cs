using System;

namespace Sherweb.HackDon.Models.Entities
{
    public class News
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; }

        public string Content { get; set; }

        public Guid PartnerId { get; set; }

        public virtual Partner Partner { get; set; }

    }
}
