using System;
using System.Collections.Generic;

namespace CoreProject.DataAccessLayer.Models;

public partial class TransferCustomer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MobileNumber { get; set; }

    public DateTime? EntryDate { get; set; }
}
