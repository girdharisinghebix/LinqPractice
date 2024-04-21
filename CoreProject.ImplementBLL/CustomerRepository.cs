using AutoMapper;
using CoreProject.DataAccessLayer;
using CoreProject.DataAccessLayer.Models;
using CoreProject.InterfaceRepository;
using CoreProject.Model;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.Design;
using System.Transactions;



namespace CoreProject.ImplementBLL
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IMapper _mapper;
        CustomerDataLayer _customerdatalayer;

        public CustomerRepository(IMapper mapper, CustomerDataLayer customerdatalayer)
        {
            _mapper = mapper;
            _customerdatalayer = customerdatalayer;
        }
        public async Task<int> InsertCustomer(CustomerBLL cust)
        {
            using var context = new BlogDbContext();
            using var transaction = context.Database.BeginTransaction();
            try
            {

                var customerModel = _mapper.Map<Customer>(cust);
                int customerid = await _customerdatalayer.InsertCustomer(customerModel);
                transaction.Commit();
                return customerid;

            }

            catch (Exception ex)
            {
                int a = 0;
                transaction.Rollback();
                return a;

            }

        }
    }
}
