using System;
using System.Collections.Generic;

namespace CoreProject.Controller.Models;

public partial class PracSubMark
{
    public int PracSubMarkId { get; set; }

    public double? Marks { get; set; }

    public int? SubjectId { get; set; }

    public virtual ICollection<PracAttemptMark> PracAttemptMarks { get; } = new List<PracAttemptMark>();

    public virtual Subject? Subject { get; set; }
}
