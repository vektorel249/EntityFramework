using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.Data.Entities;

[Table("Products")]
public class Product
{
    [Column("ProductID")]
    [Key]
    public int Id { get; set; }

    [Column("ProductName")]
    public string Name { get; set; }

    [Column("UnitPrice")]
    public decimal Price { get; set; }

    [Column("UnitsInStock")]
    public short Stock { get; set; }

    public int? CategoryID { get; set; }
    public Nullable<int> SupplierID { get; set; }

    [ForeignKey(nameof(CategoryID))]
    public Category Category { get; set; }

    [ForeignKey(nameof(SupplierID))]
    public Supplier Supplier { get; set; }
}
