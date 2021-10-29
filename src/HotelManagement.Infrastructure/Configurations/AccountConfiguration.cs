using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(x => x.Employee)
                .WithOne(e => e.Account)
                .HasForeignKey<Account>(x => x.EmployeeId);

            builder.HasOne(e => e.Role)
                .WithOne(x => x.Accound)
                .HasForeignKey<Account>(d => d.RoleId);
        }
    }
}