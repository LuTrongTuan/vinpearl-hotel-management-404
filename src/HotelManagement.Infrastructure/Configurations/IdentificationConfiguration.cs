using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configurations
{
    public class IdentificationConfiguration : IEntityTypeConfiguration<Identification>
    {
        public void Configure(EntityTypeBuilder<Identification> builder)
        {
            var data = new Identification[]
            {
                new() { Id = 1, Name = "CCCD" },
                new() { Id = 2, Name = "GPLX" },
                new() { Id = 3, Name = "Passport" }
            };
            builder.ToTable("Identification");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasData(data);
        }
    }
}