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
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(e => e.Detail)
                .WithMany(d => d.Rooms)
                .HasForeignKey(x => x.DetailId);

            builder.HasOne(e => e.Room)
                .WithMany(d => d.Receipts)
                .HasForeignKey(x => x.RoomId);
        }
    }
}