using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class HnBandContext : IdentityDbContext
    {
        public HnBandContext(DbContextOptions options) : base(options)
        {
        }
    }
}
