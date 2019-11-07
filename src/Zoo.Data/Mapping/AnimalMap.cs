using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zoo.Core.Domain;

namespace Zoo.Data.Mapping
{
    public class AnimalMap : ZooEntityTypeConfiguration<Animal>
    {
        public override void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable(nameof(Animal));
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name).HasMaxLength(256).IsRequired();

            builder.HasOne(h => h.Habitat)
                .WithMany(a => a.Animals)
                .HasForeignKey(h => h.HabitatId);

            base.Configure(builder);
        }
    }
}
