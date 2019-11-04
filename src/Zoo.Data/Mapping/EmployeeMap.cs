using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zoo.Core.Domain;

namespace Zoo.Data.Mapping
{
    public class EmployeeMap : ZooEntityTypeConfiguration<Employee> 
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable(nameof(Employee));
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FirstName).HasMaxLength(256).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(256).IsRequired();

            base.Configure(builder);
        }
    }
}
