using CoreProject.InterfaceRepository;
using CoreProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentRepository _IStudentRepository;
        public StudentController(IStudentRepository iStudentRepository)
        {
            _IStudentRepository = iStudentRepository;
        }

          [HttpGet]
        [Route("InnerJoinStudent")]
        public async Task<IActionResult> InnerJoinStudent(int Id)
        {

            //int customerid = 0;
          var  customerid =  await _IStudentRepository.InnerJoinStudentDetail(Id);

           return Ok(customerid);

        }

        [HttpGet]
        [Route("LeftJoinStudent")]
        public async Task<IActionResult> LeftJoinStudent()
        {

            //int customerid = 0;
            var customerid = await _IStudentRepository.LeftJoinStudentDetail();

            return Ok(customerid);

        }
    }
}
