using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configurations
{
    public class CustomerReceiptConfiguration : IEntityTypeConfiguration<CustomerReceipt>
    {
        public void Configure(EntityTypeBuilder<CustomerReceipt> builder)
        {
            builder.ToTable("CustomerReceipt");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(e => e.Customer)
                .WithMany(d => d.Receipts)
                .HasForeignKey(x => x.CustomerId);

            builder.HasOne(e => e.Receipt)
                .WithMany(d => d.Customers)
                .HasForeignKey(x => x.ReceiptId);
        }
    }
}