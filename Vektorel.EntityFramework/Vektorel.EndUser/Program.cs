using Vektorel.Data.Context;

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