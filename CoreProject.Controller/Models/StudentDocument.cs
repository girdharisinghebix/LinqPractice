using System;
using System.Collections.Generic;

namespace CoreProject.Controller.Models;

public partial class StudentDocument
{
    public int StudentDcoumentId { get; set; }

    public int? StudentId { get; set; }

    public int? DocumentId { get; set; }
}
