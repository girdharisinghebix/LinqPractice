using System;
using System.Collections.Generic;

namespace CoreProject.Controller.Models;

public partial class StudentAddressDetail
{
    public int AddressId { get; set; }

    public int? StudentId { get; set; }

    public int? PinCode { get; set; }

    public string? AddressDetail { get; set; }

    public virtual Student? Student { get; set; }
}
