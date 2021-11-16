using System.Reflection;
using HotelManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        // define connection string here
        private const string ConnectionString = @"Data Source=LAPTOP-TPLS3OIB\SQLEXPRESS;Initial Catalog=Hotel_Phuongbo;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public virtual DbSet<ServiceReceipt> ServiceReceipts { get; set; }
        public virtual DbSet<Identification> Identifications { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
    }
}