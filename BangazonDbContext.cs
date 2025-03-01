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
                PostalCode = "35901",
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
            new Products { ProductId = 1, ProductTypeId = 1, SellerUid = "1", Name = "Widget", Description = "A widget that does stuff", Price = 9.99m, Quantity = 100, DateAdded = new DateTime(2019, 1, 1) },
            new Products { ProductId = 2, ProductTypeId = 2, SellerUid = "2", Name = "Gadget", Description = "A gadget that does stuff", Price = 19.99m, Quantity = 50, DateAdded = new DateTime(2019, 1, 1) }
        );
        modelBuilder.Entity<ProductTypes>().HasData(
            new ProductTypes { ProductTypeId = 1, Name = "Widgets", Description = "Widgets are cool", ImageUrl = "" },
            new ProductTypes { ProductTypeId = 2, Name = "Gadgets", Description = "Gadgets are cooler", ImageUrl = "" }
        );
        modelBuilder.Entity<Sellers>().HasData(
            new Sellers { SellerId = "1", FirstName = "Jane", LastName = "Doe", Email = "seller@email.com", PhoneNumber = "555-555-5555", City = "Decatur", State = "Georgia", PostalCode = "32323" },
        );
        modelBuilder.Entity<Orders>().HasData(
            new Orders { OrdersId = 1, Quantity = 10, IsFullfilled = false, TotalPrice = 450M , OrderDate = new DateTime(2019, 1, 1), PaymentDate = DateTime.Now },
            new Orders { OrdersId = 2, Quantity = 5, IsFullfilled = true, TotalPrice = 350M, OrderDate = new DateTime(2019, 1, 1), PaymentDate = DateTime.Now }

            );
        modelBuilder.Entity<OrderItems>().HasData(
            new OrderItems { OrderItemsId = 1, Quantity = 2, TotalPrice = 45m },
            new OrderItems { OrderItemsId = 2, Quantity = 1, TotalPrice = 35m }
        );
        modelBuilder.Entity<Payments>().HasData(
            new Payments { PaymentId = 1, AccountNumber = "1234567890" },
            new Payments { PaymentId = 2, AccountNumber = "0987654321" }
        );
        modelBuilder.Entity<CustomerOrders>().HasData(
            new CustomerOrders { CustomerOrderId = 1 },
            new CustomerOrders { CustomerOrderId = 2 }
        );
        modelBuilder.Entity<SellerOrders>().HasData(
            new SellerOrders { SellerOrdersId = 1 },
            new SellerOrders { SellerOrdersId = 2 }
        );
        modelBuilder.Entity<SellerDashboard>().HasData(
            new SellerDashboard { SellerDashBoardId = 1, TotalRevenue = 19.98m, TotalOrders = 2 },
            new SellerDashboard { SellerDashBoardId = 2, TotalRevenue = 19.99m, TotalOrders = 1 }
        );
        modelBuilder.Entity<AccountType>().HasData(
           new AccountType { AccountTypeId = 1, AcctType = AccountTypeEnum.Customer },
              new AccountType { AccountTypeId = 2, AcctType = AccountTypeEnum.Seller }
        );
        modelBuilder.Entity<OrderStatus>().HasData(
            new OrderStatus { OrderStatusId = 1, OrderStat = OrderStatusEnum.Pending },
            new OrderStatus { OrderStatusId = 2, OrderStat = OrderStatusEnum.Completed }
        );
        modelBuilder.Entity<PaymentTypes>().HasData(
            new PaymentTypes { PaymentTypeId = 1, PmtType = PaymentTypeEnum.PayPal },
            new PaymentTypes { PaymentTypeId = 2, PmtType = PaymentTypeEnum.ApplePay }
        );
    }
}

    