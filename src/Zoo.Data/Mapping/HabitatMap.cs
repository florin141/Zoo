using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zoo.Core.Domain;

namespace Zoo.Data.Mapping
{
    public class HabitatMap : ZooEntityTypeConfiguration<Habitat>
    {
        public override void Configure(EntityTypeBuilder<Habitat> builder)
        {
            builder.ToTable(nameof(Habitat));
            builder.HasKey(h => h.Id);

            builder.Property(h => h.Name).HasMaxLength(256).IsRequired();

            base.Configure(builder);
        }
    }
}
