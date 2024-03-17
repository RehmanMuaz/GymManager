using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using GM.Core.Models;

namespace GM.Core.Data
{
    public class GMDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; } = null;
        public DbSet<Transaction> Transactions { get; set; }

        public GMDbContext(DbContextOptions<GMDbContext> contextOptions)
             : base(contextOptions)
        {
        }
    }
}
