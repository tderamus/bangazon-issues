using bangazon_issues.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<BangazonDbContext>(builder.Configuration["BangazonDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//*****************************************************GET API CALLS****************************************************************

// GET All Customers
app.MapGet("api/customers", (BangazonDbContext db) =>
{
    if(db.Customers == null)
{
    return Results.NotFound();
}
    return Results.Ok(db.Customers.ToList());
});

// GET All CustomerOrders
app.MapGet("api/customerorders", (BangazonDbContext db) =>
{
    if (db.CustomersOrders == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.CustomersOrders.ToList());
});

// GET All OrderItems
app.MapGet("api/orderitems", (BangazonDbContext db) =>
{
    if (db.OrderItems == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.OrderItems.ToList());
});

// GET SellerOrders
app.MapGet("api/sellerorders", (BangazonDbContext db) =>
{
    if (db.SellersOrders == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.SellersOrders.ToList());
});

// GET All Orders
app.MapGet("api/orders", (BangazonDbContext db) =>
{
    if (db.Orders == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.Orders.ToList());
});

// GET All Products
app.MapGet("api/products", (BangazonDbContext db) =>
{
    if (db.Products == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.Products.ToList());
});

// GET All ProductTypes
app.MapGet("api/producttypes", (BangazonDbContext db) =>
{
    if (db.ProductTypes == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.ProductTypes.ToList());
});

// GET All Payments
app.MapGet("api/payments", (BangazonDbContext db) =>
{
    if (db.Payments == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.Payments.ToList());
});

// GET All PaymentTypes
app.MapGet("api/paymenttypes", (BangazonDbContext db) =>
{
    if (db.PaymentTypes == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.PaymentTypes.ToList());
});

// GET All Sellers
app.MapGet("api/sellers", (BangazonDbContext db) =>
{
    if (db.Sellers == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.Sellers.ToList());
});

// GET All SellerDashboard
app.MapGet("api/sellerdashboard", (BangazonDbContext db) =>
{
    if (db.SellerDashboard == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.SellerDashboard.ToList());
});

// GET All AccountType
app.MapGet("api/accounttype", (BangazonDbContext db) =>
{
    if (db.AccountType == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.AccountType.ToList());
});

// GET All OrderStatus
app.MapGet("api/orderstatus", (BangazonDbContext db) =>
{
    if (db.OrderStatus == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(db.OrderStatus.ToList());
});

//*****************************************************POST (Create) API CALLS****************************************************************

// Create a new Customer
app.MapPost("api/customers", (BangazonDbContext db, Customers customer) =>
{
    db.Customers.Add(customer);
    db.SaveChanges();
    return Results.Created($"/api/customers/{customer.Uid}", customer);
});


app.Run();


