using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoomerce.Api.Customers
{
  public  interface ICustomer
    {
        public Task<(bool IsSuccess, IEnumerable<Models.Customer> customers)> GetCustomerAsync();

    }
}
