using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.Data.Entities;

[Table("EmployeeVehicles", Schema = "vektorel")]
public class EmployeeVehicle
{
    public int ID { get; set; }
    public int EmployeeID { get; set; }
    public int VehicleID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int? GivenKm { get; set; }
    public int? TakenKm { get; set; }

    [ForeignKey(nameof(EmployeeID))]
    public Employee Employee { get; set; }

    [ForeignKey(nameof(VehicleID))]
    public Vehicle Vehicle { get; set; }
}