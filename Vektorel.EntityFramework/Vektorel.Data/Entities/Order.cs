using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.Data.Entities;

[Table("Orders")]
public class Order
{
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public int EmployeeID { get; set; }
}