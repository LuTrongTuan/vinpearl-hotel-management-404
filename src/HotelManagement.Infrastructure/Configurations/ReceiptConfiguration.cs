using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configurations
{
    public class ReceiptConfiguration : IEntityTypeConfiguration<Receipt>
    {
        public void Configure(EntityTypeBuilder<Receipt> builder)
        {
            builder.ToTable("Receipt");
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(e => e.Customer)
                .WithMany(d => d.Receipts)
                .HasForeignKey(d => d.CustomerId);

            builder.HasOne(e => e.Employee)
                .WithMany(d => d.Receipt)
                .HasForeignKey(x => x.EmployeeId);

            builder.HasOne(e => e.Identification)
                .WithMany(d => d.Receipts)
                .HasForeignKey(x => x.IdentificationId);
        }
    }
}