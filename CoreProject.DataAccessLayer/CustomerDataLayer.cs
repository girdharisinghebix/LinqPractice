using CoreProject.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CoreProject.DataAccessLayer
{
    public  class CustomerDataLayer
    {

        BlogDbContext db = new BlogDbContext();     
        public async Task<int> InsertCustomer(Customer cust)
        {
          
               // db.Customers.AddAsync(cust);
               await db.Customers.AddAsync(cust);
                db.SaveChanges();
                var id =  cust.Id;
                //db.SaveChangesAsync();
                return id;
            

           
        }
    }
}
