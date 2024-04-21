using CoreProject.DataAccessLayer.Models;
using CoreProject.InterfaceRepository;
using CoreProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerRepository _ICustomerRepository;
        public CustomerController(ICustomerRepository iCustomerRepository)
        {
           _ICustomerRepository = iCustomerRepository;
        }


        [HttpPost]
        [Route("AddCustomer")]
        public async Task<IActionResult> AddCustomer([FromBody] CustomerBLL model)
        {

            //int customerid = 0;
          var  customerid =  await  _ICustomerRepository.InsertCustomer(model);

           return Ok(customerid);

        }
    }
}
