using System;
using System.Data.Entity;

namespace Songs_of_groups_example
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnectionString")
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
