using System;
using CustomerSolution.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSolution.CustomerData
{
   public  interface ICustomerDetails
    {
        public List<Customer> GetCustomers();

        public Customer GetCustomerById(Guid Id);


        public List<Customer> GetCustomerByCategory(string name);
    }
}
