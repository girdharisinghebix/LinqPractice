namespace CoreProject.InterfaceBLL
{
    public interface ICustomerRepository
    {
        Task<int> InsertCustomer(Customer cust);
    }
