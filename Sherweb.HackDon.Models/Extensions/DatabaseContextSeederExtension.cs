using Sherweb.HackDon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sherweb.HackDon.Models.Extensions
{
    public static class DbContextSeederExtension
    {
        public static void SeedDevData(this DatabaseContext context)
        {
            context.SeedCauses();
        }
    }
}