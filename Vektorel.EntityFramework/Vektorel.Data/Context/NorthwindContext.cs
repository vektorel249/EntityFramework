﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Vektorel.Data.Entities;

namespace Vektorel.Data.Context;

public class NorthwindContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
        optionsBuilder.UseSqlServer("Server=192.168.254.198;Database=Northwind;User Id=va249;Password=123;TrustServerCertificate=true;");

        optionsBuilder.UseLoggerFactory(LoggerFactory.Create(builder =>
        {
            builder.AddDebug();
        }));
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<EmployeeVehicle> EmployeeVehicles { get; set; }
}
