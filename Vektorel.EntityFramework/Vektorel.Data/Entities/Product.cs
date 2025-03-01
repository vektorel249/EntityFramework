using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.Data.Entities;

[Table("Products")]
public class Product
{
    [Column("ProductID")]
    public int Id { get; set; }
    [Column("ProductName")]
    public string Name { get; set; }
    [Column("UnitPrice")]
    public decimal Price { get; set; }
    [Column("UnitsInStock")]
    public short Stock { get; set; }
}