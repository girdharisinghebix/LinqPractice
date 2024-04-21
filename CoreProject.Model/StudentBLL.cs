using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Model
{
    public  class StudentBLL
    {
        public int? StudentId { get; set; }
        public string? StudentName { get; set; }

        public string? FatherName { get; set; }

        public string? MotherName { get; set; }

        public int? CourseId { get; set; }

        public string? CourseName { get; set; }

        public List<StudentAddressDetailBLL>?  stdaddressdetail { get; set; }

        public List<SemesterMarkBLL>? stdsemesterbll { get; set; }

        public int? TotalMarks { get; set; }

        
    }


    public class StudentAddressDetailBLL

    {
        public int? AddressId { get; set; }
        public int? StudentId { get; set; }
        public int? PinCode { get; set; }
        public string? AddressDetail { get; set; }

    }

    public class SemesterMarkBLL
    {
        public int? SemesterId { get; set; }
        public string? SemesterName { get; set; }
        public int? SubjectId { get; set; }       
        public string? SubjectName { get; set; }
        public double? PracticalMark { get; set; }
        public int? PracticalAttemptMark { get; set; }
        public double? TheoryMark { get; set; }
        public int? TheoryAttemptMark { get; set; }

        public double? TotalSemesterMarks { get; set; }

    }




}
