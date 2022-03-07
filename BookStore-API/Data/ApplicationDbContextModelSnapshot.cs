using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Data
{
        public class ApplicationDbContextModelSnapshot : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContextModelSnapshot(DbContextOptions options) : base(options)
        {
        }
    }
}
