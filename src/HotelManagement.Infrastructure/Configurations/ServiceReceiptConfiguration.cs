using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configurations
{
    public class ServiceReceiptConfiguration : IEntityTypeConfiguration<ServiceReceipt>
    {
        public void Configure(EntityTypeBuilder<ServiceReceipt> builder)
        {
            builder.ToTable("ServiceReceipt");
            builder.HasKey(e => new {e.ReceiptDetailId, e.ServiceId});

            builder.HasOne(e => e.Service)
                .WithMany(d => d.ServiceReceipts)
                .HasForeignKey(d => d.ServiceId);

            builder.HasOne(e => e.ReceiptDetail)
                .WithMany(d => d.ServiceReceipts)
                .HasForeignKey(x => x.ReceiptDetailId);
        }
    }
}