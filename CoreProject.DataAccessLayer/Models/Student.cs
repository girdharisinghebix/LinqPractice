using System;
using System.Collections.Generic;

namespace CoreProject.DataAccessLayer.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public virtual ICollection<StudentAddressDetail> StudentAddressDetails { get; } = new List<StudentAddressDetail>();

    public virtual ICollection<StudentCourseM> StudentCourseMs { get; } = new List<StudentCourseM>();
}
