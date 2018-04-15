using System;

namespace Sherweb.HackDon.Models.Entities
{
    public class UserCategory
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid CategoryId { get; set; }

        public User User { get; set; }

        public Category Category { get; set; }
    }
}
