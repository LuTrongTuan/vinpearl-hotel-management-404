using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configurations
{
    public class RoomReceiptConfiguration : IEntityTypeConfiguration<RoomReceipt>
    {
        public void Configure(EntityTypeBuilder<RoomReceipt> builder)
        {
            builder.ToTable("RoomReceipt");
            builder.HasKey(e => new { e.ReceiptDetailId, e.RoomId });

            builder.HasOne(e => e.ReceiptDetail)
                .WithMany(d => d.RoomReceipts)
                .HasForeignKey(x => x.ReceiptDetailId);

            builder.HasOne(e => e.Room)
                .WithMany(d => d.RoomReceipts)
                .HasForeignKey(x => x.RoomId);
        }
    }
}