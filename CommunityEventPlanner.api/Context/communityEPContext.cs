using CommunityEventPlanner.api.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CommunityEventPlanner.api.Context
{
    public class communityEPContext: DbContext
    {
        public communityEPContext(DbContextOptions<communityEPContext> options)
     : base(options)
        {
        }

        public DbSet<User> users { get; set; }
        public DbSet<CommunityEvent> communityEvents { get; set; }
        public DbSet<CommunityEventSubscription> CommunityEventSubscriptions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CommunityEventSubscription>().HasIndex(a => new { a.UserId, a.EventId }).IsUnique();

            base.OnModelCreating(modelBuilder);
        }

    }
}
