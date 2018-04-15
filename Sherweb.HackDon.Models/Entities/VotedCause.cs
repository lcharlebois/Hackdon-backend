using System;

namespace Sherweb.HackDon.Models.Entities
{
    public class VotedCause
    {
        public Guid Id { get; set; }

        public bool LikedIt { get; set; }

        public Guid CauseId { get; set; }
        
        public Cause Cause { get; set; }

        public double Ratio { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}