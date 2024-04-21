using System;
using System.Collections.Generic;

namespace CoreProject.DataAccessLayer.Models;

public partial class Semester
{
    public int SemesterId { get; set; }

    public string? SemesterName { get; set; }

    public int? Status { get; set; }

    public int? CourseId { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<Subject> Subjects { get; } = new List<Subject>();
}
