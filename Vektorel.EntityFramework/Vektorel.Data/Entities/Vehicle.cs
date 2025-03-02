using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vektorel.Data.Enums;

namespace Vektorel.Data.Entities;

[Table("Vehicles", Schema = "vektorel")]
public class Vehicle
{
    public Vehicle()
    {
        IsActive = true;
    }
    [Key]
    public int VehicleID { get; set; }
    [MaxLength(10)]
    public string PlateNumber { get; set; }
    [MaxLength(10)]
    public string Brand { get; set; }
    public DateTime? LastMaintanenceDate { get; set; }
    public VehicleType VehicleType { get; set; }
    public bool IsActive { get; set; }
}