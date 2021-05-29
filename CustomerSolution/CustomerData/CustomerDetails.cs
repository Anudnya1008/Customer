using CustomerSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSolution.CustomerData
{
    public class CustomerDetails : ICustomerDetails
    {
        private CustomerContext _customerContext;

        public CustomerDetails(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }
        public List<Customer> GetCustomerByCategory(string name)
        {
            List<Customer> allcustomers = _customerContext.Customer.Where(x => x.CustomerCategoryName == name).ToList();

            return allcustomers;
        }

        public Customer GetCustomerById(Guid Id)
        {
            return _customerContext.Customer.SingleOrDefault(x => x.Id == Id);
        }

        public List<Customer> GetCustomers()
        {
            return _customerContext.Customer.ToList();
        }
    }
}
