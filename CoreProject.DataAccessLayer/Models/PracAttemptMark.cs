using System;
using System.Collections.Generic;

namespace CoreProject.DataAccessLayer.Models;

public partial class PracAttemptMark
{
    public int AttemptMarksId { get; set; }

    public int? StudentId { get; set; }

    public int? PraAttemptSubMark { get; set; }

    public int? PracSubMarkId { get; set; }

    public virtual PracSubMark? PracSubMark { get; set; }
}
