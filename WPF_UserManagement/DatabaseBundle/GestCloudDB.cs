using System;
using Microsoft.EntityFrameworkCore;

namespace Packt.CS7
{
    public class GestCloudDB : DbContext
    {
        // properties that map to the tables in the db
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // for Microsoft SQL Server
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" + "Initial Catalog=GestCloud;" +
                "Integrated Security=true;");
        }
    }
}
