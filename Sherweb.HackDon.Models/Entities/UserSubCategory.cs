using System;
using System.Collections.Generic;
using System.Text;

namespace Sherweb.HackDon.Models.Entities
{
    public class UserSubCategory
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid SubCategoryId { get; set; }

        public User User { get; set; }

        public SubCategory SubCategory { get; set; }
    }
}
