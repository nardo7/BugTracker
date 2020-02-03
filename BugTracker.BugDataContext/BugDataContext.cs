using System;
using BugTracker.BugDataModel;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.BugDataContext
{
    public class BugContext:DbContext
    {
        public DbSet<Bug> Bugs { get; set; }

        public DbSet<Priority> Priorities { get; set; }

        public BugContext(DbContextOptions options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }

    }
}
