using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.Data.Entities;

[Table("Order Details")]
[PrimaryKey(nameof(OrderID), nameof(ProductID))]
public class OrderDetail
{
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public short Quantity { get; set; }
    public float Discount { get; set; }
    public decimal UnitPrice { get; set; }

    [ForeignKey(nameof(ProductID))]
    public Product Product { get; set; } //navigation property
}