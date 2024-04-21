using System;
using System.Collections.Generic;

namespace CoreProject.DataAccessLayer.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public int? Status { get; set; }

    public int? SemesterId { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<PracSubMark> PracSubMarks { get; } = new List<PracSubMark>();

    public virtual Semester? Semester { get; set; }

    public virtual ICollection<ThSubMark> ThSubMarks { get; } = new List<ThSubMark>();
}
