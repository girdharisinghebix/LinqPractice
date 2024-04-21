using System;
using System.Collections.Generic;

namespace CoreProject.DataAccessLayer.Models;

public partial class User
{
    public int? UserId { get; set; }

    public string? Password { get; set; }
}
