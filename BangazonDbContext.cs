using Microsoft.EntityFrameworkCore;
using bangazon_issues.Models;
using Npgsql.TypeMapping;
using static bangazon_issues.Models.AccountType;
using static bangazon_issues.Models.OrderStatus;
using static bangazon_issues.Models.PaymentTypes;

public class BangazonDbContext : DbContext
{
    public DbSet<Customers> Customers { get; set; }
    public DbSet<OrderItems> OrderItems { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Payments> Payments { get; set; }
    public DbSet<PaymentTypes> PaymentTypes { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<ProductTypes> ProductTypes { get; set; }
    public DbSet<Sellers> Sellers { get; set; }
    public DbSet<SellerOrders> SellersOrders { get; set; }
    public DbSet<SellerDashboard> SellerDashboard { get; set; }
    public DbSet<CustomerOrders> CustomersOrders { get; set; }
    public DbSet<AccountType> AccountType { get; set; }
    public DbSet<OrderStatus> OrderStatus { get; set; }



    public BangazonDbContext(DbContextOptions<BangazonDbContext> context) : base(context)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Set up composite keys to be auto-generated

        modelBuilder.Entity<OrderItems>()
            .Property(o => o.OrderItemsId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Orders>()
            .Property(o => o.OrdersId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Payments>()
            .Property(p => p.PaymentId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<PaymentTypes>()
            .Property(p => p.PaymentTypeId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<Products>()
            .Property(p => p.ProductId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<ProductTypes>()
            .Property(p => p.ProductTypeId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<SellerOrders>()
            .Property(s => s.SellerOrdersId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<CustomerOrders>()
            .Property(c => c.CustomerOrderId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<SellerDashboard>()
            .Property(s => s.SellerDashBoardId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<AccountType>()
            .Property(a => a.AccountTypeId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<OrderStatus>()
            .Property(o => o.OrderStatusId)
            .ValueGeneratedOnAdd();

        // Build DB Relationships

        modelBuilder.Entity<Customers>()
            .HasOne(c => c.CustomerOrders)
            .WithOne(co => co.Customer)
            .HasForeignKey<CustomerOrders>(co => co.CustomerUid)
            .HasPrincipalKey<Customers>(c => c.Uid);

        modelBuilder.Entity<OrderItems>()
            .HasOne(oi => oi.Orders)
            .WithMany(o => o.OrderItems)
            .HasForeignKey(oi => oi.OrdersId);

        modelBuilder.Entity<Orders>()
            .HasOne(o => o.Payment)
            .WithOne(p => p.Orders)
            .HasForeignKey<Orders>(o => o.PaymentId);


        // Add seed data

        var order1Id = Guid.NewGuid().ToString();
        var order2Id = Guid.NewGuid().ToString();
        var payment1Id = Guid.NewGuid().ToString();
        var payment2Id = Guid.NewGuid().ToString();

        modelBuilder.Entity<Customers>().HasData(
            new Customers
            {
                Uid = "1",
                FirstName = "Sally",
                LastName = "Smith",
                Email = "jon@jon.com",
                PhoneNumber = "256-490-1245",
                City = "Gadsden",
                State = "Alabama",
                PostalCode = "35901"
            },
            new Customers
            {
                Uid = "2",
                FirstName = "Jon",
                LastName = "Doe",
                Email = "jondoe@email.com",
                PhoneNumber = "256-555-5555",
                City = "Birmingham",
                State = "Alabama",
                PostalCode = "35203",
            }
        );
        modelBuilder.Entity<Products>().HasData(
            new Products { ProductId = Guid.NewGuid().ToString(), ProductTypeId = 1, SellerUid = "1", Name = "Widget", Description = "A widget that does stuff", Price = 9.99m, Quantity = 100, DateAdded = new DateTime(2019, 1, 1) },
            new Products { ProductId = Guid.NewGuid().ToString(), ProductTypeId = 2, SellerUid = "2", Name = "Gadget", Description = "A gadget that does stuff", Price = 19.99m, Quantity = 50, DateAdded = new DateTime(2019, 1, 1) }
        );
        modelBuilder.Entity<ProductTypes>().HasData(
            new ProductTypes { ProductTypeId = Guid.NewGuid().ToString(), Name = "Widgets", Description = "Widgets are cool", ImageUrl = "" },
            new ProductTypes { ProductTypeId = Guid.NewGuid().ToString(), Name = "Gadgets", Description = "Gadgets are cooler", ImageUrl = "" }
        );
        modelBuilder.Entity<Sellers>().HasData(
            new Sellers { SellerId = Guid.NewGuid().ToString(), FirstName = "Jane", LastName = "Doe", Email = "seller@email.com", PhoneNumber = "555-555-5555", City = "Decatur", State = "Georgia", PostalCode = "32323" },
            new Sellers { SellerId = Guid.NewGuid().ToString(), FirstName = "John", LastName = "Smith", Email = "jsmith@jsmith.com", PhoneNumber = "256-555-5555", City = "Birmingham", State = "Alabama", PostalCode = "35203", }
        );
        modelBuilder.Entity<Orders>().HasData(
            new Orders { OrdersId = order1Id, Quantity = 10, IsFullfilled = false, TotalPrice = 450M , OrderDate = new DateTime(2019, 1, 1), PaymentDate = DateTime.Now },
            new Orders { OrdersId = order2Id, Quantity = 5, IsFullfilled = true, TotalPrice = 350M, OrderDate = new DateTime(2019, 1, 1), PaymentDate = DateTime.Now }

            );
        modelBuilder.Entity<OrderItems>().HasData(
            new OrderItems { OrderItemsId = Guid.NewGuid().ToString(), OrdersId = order1Id, Quantity = 2, TotalPrice = 45m },
            new OrderItems { OrderItemsId = Guid.NewGuid().ToString(), OrdersId = order2Id, Quantity = 1, TotalPrice = 35m }
        );
        modelBuilder.Entity<Payments>().HasData(
            new Payments { PaymentId = payment1Id, PaymentDate = DateTime.UtcNow, AccountNumber = "1234567890" },
            new Payments { PaymentId = payment2Id, PaymentDate = DateTime.UtcNow, AccountNumber = "0987654321" }
        );
        modelBuilder.Entity<CustomerOrders>().HasData(
            new CustomerOrders { CustomerOrderId = Guid.NewGuid().ToString(), CustomerUid = "1" },
            new CustomerOrders { CustomerOrderId = Guid.NewGuid().ToString(), CustomerUid = "2" }
        );
        modelBuilder.Entity<SellerOrders>().HasData(
            new SellerOrders { SellerOrdersId = Guid.NewGuid().ToString() },
            new SellerOrders { SellerOrdersId = Guid.NewGuid().ToString() }
        );
        modelBuilder.Entity<SellerDashboard>().HasData(
            new SellerDashboard { SellerDashBoardId = Guid.NewGuid().ToString(), TotalRevenue = 19.98m, TotalOrders = 2 },
            new SellerDashboard { SellerDashBoardId = Guid.NewGuid().ToString(), TotalRevenue = 19.99m, TotalOrders = 1 }
        );
        modelBuilder.Entity<AccountType>().HasData(
           new AccountType { AccountTypeId = Guid.NewGuid().ToString(), TypeAcct = AcctType.Admin },
           new AccountType { AccountTypeId = Guid.NewGuid().ToString(), TypeAcct = AcctType.Seller }
        );
        modelBuilder.Entity<OrderStatus>().HasData(
            new OrderStatus { OrderStatusId = Guid.NewGuid().ToString(), OrderState = StatusOfOrder.Pending },
            new OrderStatus { OrderStatusId = Guid.NewGuid().ToString(), OrderState = StatusOfOrder.Completed }
        );
        modelBuilder.Entity<PaymentTypes>().HasData(
            new PaymentTypes { PaymentTypeId = Guid.NewGuid().ToString(), TypePayment = PmtType.PayPal },
            new PaymentTypes { PaymentTypeId = Guid.NewGuid().ToString(), TypePayment = PmtType.ApplePay }
        );
    }
}

    