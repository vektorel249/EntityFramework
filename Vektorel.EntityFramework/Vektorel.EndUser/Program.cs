using Vektorel.Data.Context;
using Vektorel.Data.Entities;

var context = new NorthwindContext();
var categories = context.Categories
                        .OrderBy(o => o.CategoryID)
                        .ToList();
foreach (var category in categories)
{
    Console.WriteLine("{0, 2} - {1}", category.CategoryID, category.CategoryName);
}
Console.WriteLine();
var products = context.Products
                      .Where(f => f.Name.StartsWith("C"))
                      .Take(3)
                      .OrderBy(o => o.Name)
                      .ToList();
products = context.Products.ToList();
products = context.Products
                  .Take(3)
                  .OrderBy(o => o.Name)
                  .Where(f => f.Name.StartsWith("C"))
                  .ToList();

foreach (var product in products)
{
    Console.WriteLine("{0, 2} - {1, -20} - {2}", product.Id, product.Name, product.Price);
}
#region Yeni Tablo


var vehicles = context.Vehicles.ToList();
foreach (var vehicle in vehicles)
{
    Console.WriteLine(vehicle.Brand + " " + vehicle.VehicleType);
}

#endregion

#region Yeni Kayıt
var saved = false;
if (!saved)
{
    var newVehicle = new EmployeeVehicle
    {
        EmployeeID = 1,
        VehicleID = 1,
        StartDate = DateTime.Now.AddMonths(-5),
    };

    context.EmployeeVehicles.Add(newVehicle);
    context.SaveChanges(); 
}
else
{
    var savedEntity = context.EmployeeVehicles.First(f => f.ID == 1);
    savedEntity.EndDate = DateTime.Now;
    context.EmployeeVehicles.Update(savedEntity);
    context.SaveChanges();
}

var shouldDelete = false;
if (shouldDelete)
{
    var savedEntity = context.EmployeeVehicles.First(f => f.ID == 1);
    context.EmployeeVehicles.Remove(savedEntity);
    context.SaveChanges();
}
#endregion


//"SELECT * FROM Products WHERE Name = '"+ txtName.Text +"'"
// SELECT * FROM Products WHERE Name = 'Chai'
// SELECT * FROM Products WHERE Name = ''; GO DROP DATABASE Northwind; --'

// SqlParameter
//"SELECT * FROM Products WHERE Name = @p1"
//@p1 = ''; GO DROP DATABASE Northwind --'

// %LENOVO%





/*
 Func<string, string, int> a;

 int a(string b, string c)
 {
    return 0;
 }

 Action<string, int> a
 
 void a(string b, int c)
 {
  
 }
 */




/*
 
 EF (Entity Framework) => Database First
                       => Code First => Mİgration

Yeni bir yapı değişikliği için kod oluşturma süreci 
-- Add-Migration VehicleEmployeeTable -P Vektorel.Data -C NorthwindContext -S Vektorel.Data 


Oluşan kodun veritabanına yansıtılması
-- Update-Database -Project Vektorel.Data -Context NorthwindContext -S Vektorel.Data -Verbose
 */