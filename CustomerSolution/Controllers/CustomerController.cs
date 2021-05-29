using CustomerSolution.CustomerData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSolution.Controllers
{

    [ApiController]

    public class CustomerController : ControllerBase
    {

        private  ICustomerDetails _customerDetails;

            public CustomerController(ICustomerDetails customerDetails)
        {
            _customerDetails = customerDetails;
        }

        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetCustomers()
        {
            return Ok(_customerDetails.GetCustomers());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetCustomerById(Guid id )
        {
            var customer = _customerDetails.GetCustomerById(id);
            if (customer != null)
            {
                return Ok(customer);
            }
            return NotFound("Employee Was Not Found");
        }
        [HttpGet]
        [Route("api/[controller]/GetCustomerByCategory/{id}")]

        public IActionResult GetCustomerByCategory(string id)
        {
            var allcustomer = _customerDetails.GetCustomerByCategory(id);
            if (allcustomer != null)
            {
                return Ok(allcustomer);
            }
            return NotFound("Employee Was Not Found");
        }
    }
}
