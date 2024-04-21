using System;
using System.Collections.Generic;

namespace CoreProject.Controller.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MobileNumber { get; set; }

    public DateTime? EntryDate { get; set; }
}
