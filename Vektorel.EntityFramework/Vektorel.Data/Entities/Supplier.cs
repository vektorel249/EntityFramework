﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Vektorel.Data.Entities;

[Table("Suppliers")]
public class Supplier
{
    public int SupplierID { get; set; }
    public string CompanyName { get; set; }
    public string ContactName { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
}