using Entity;
using Microsoft.EntityFrameworkCore;
using System;


namespace DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(connectionString: "Host = localhost; Port = 1111; Database = Map; User Id = postgres; Password = ny;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use this to configure the model
        }
        public DbSet<Map> Map { get; set; }
        

    }
}
