using System;
using System.Collections.Generic;

namespace CoreProject.Controller.Models;

public partial class ThAttemptMark
{
    public int AttemptMarksId { get; set; }

    public int? StudentId { get; set; }

    public int? ThAttemptSubMark { get; set; }

    public int? ThSubMarkId { get; set; }

    public virtual ThSubMark? ThSubMark { get; set; }
}
