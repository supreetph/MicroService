using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecoomerce.Api.Customers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer _customer;
        public CustomerController(ICustomer customer)
        {
            this._customer = customer;

        }
        [HttpGet]
        public async Task<IActionResult> GetCustomerAsyc()
        {
            var (IsSuccess, customers) = await _customer.GetCustomerAsync();
            if(IsSuccess)
            {
                return Ok(customers);
            }
            else
            {
                return NotFound();
            }
           

        }
    }
}
