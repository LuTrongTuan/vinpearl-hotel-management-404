using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configurations
{
    public class ReceiptDetailConfiguration : IEntityTypeConfiguration<ReceiptDetail>
    {
        public void Configure(EntityTypeBuilder<ReceiptDetail> builder)
        {
            builder.ToTable("ReceiptDetail");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(e => e.Receipt)
                .WithOne(d => d.Detail)
                .HasForeignKey<ReceiptDetail>(x => x.ReceiptId);

            builder.HasOne(e => e.Room)
                .WithMany(d => d.Details)
                .HasForeignKey(x => x.RoomId);
        }
    }
}