using CoreProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.InterfaceRepository
{
     public interface IStudentRepository
    {
        Task<List<StudentBLL>> InnerJoinStudentDetail(int id);

        Task<List<StudentBLL>> LeftJoinStudentDetail();
    }
}
