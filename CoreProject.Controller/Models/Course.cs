using System;
using System.Collections.Generic;

namespace CoreProject.Controller.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public int? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ICollection<Semester> Semesters { get; } = new List<Semester>();

    public virtual ICollection<StudentCourseM> StudentCourseMs { get; } = new List<StudentCourseM>();
}
