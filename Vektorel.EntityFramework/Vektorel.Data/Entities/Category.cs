using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.Data.Entities;

[Table("Categories")]
public class Category
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
}