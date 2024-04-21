using CoreProject.Model;

namespace CoreProject.InterfaceRepository
{
    public interface ICustomerRepository
    {
        Task<int> InsertCustomer(CustomerBLL cust);



    }

}