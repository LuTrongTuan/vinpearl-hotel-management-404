using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            var data = new Role[]
            {
                new() { Id = 1, Name = "Nhân viên"},
                new() {Id = 2, Name = "Quản lý"}
            };

            builder.ToTable("Role");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            // add role
            builder.HasData(data);
        }
    }
}