using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSolution.Model
{
    public class Customer
    {

        public Guid Id { get; set; }

        public string CustomerName { get; set; }
        
        public string CustomerCategoryName { get; set; }
        

        public string PrimaryContact { get; set; }

        public string PhoneNumber  { get; set; }

        public string CityName { get; set; }



    }
}
