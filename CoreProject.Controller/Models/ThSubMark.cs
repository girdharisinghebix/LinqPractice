using System;
using System.Collections.Generic;

namespace CoreProject.Controller.Models;

public partial class ThSubMark
{
    public int ThSubMarkId { get; set; }

    public double? Marks { get; set; }

    public int? SubjectId { get; set; }

    public virtual Subject? Subject { get; set; }

    public virtual ICollection<ThAttemptMark> ThAttemptMarks { get; } = new List<ThAttemptMark>();
}
