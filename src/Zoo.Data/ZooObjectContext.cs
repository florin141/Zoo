using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Zoo.Data.Mapping;

namespace Zoo.Data
{
    public class ZooObjectContext : DbContext
    {
        public ZooObjectContext(DbContextOptions<ZooObjectContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new AnimalMap());
            modelBuilder.ApplyConfiguration(new HabitatMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
