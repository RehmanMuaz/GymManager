using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using GymManager.Core.Models;

namespace GymManager.Infrastructure.Data
{
    public class GMContext : DbContext
    {
        public DbSet<Member> Members { get; set; } = null;
        public DbSet<Transaction> Transactions { get; set; }

        public GMContext(DbContextOptions<GMContext> contextOptions)
             : base(contextOptions)
        {
        }
    }
}
