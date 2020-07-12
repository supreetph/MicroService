using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecoomerce.APi.Products.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecoomerce.APi.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Iproduct prod;

      
        public ProductController(Iproduct iproduct)
        {
            this.prod = iproduct;

        }
        [HttpGet]
        public async Task<IActionResult> GetProductsAsync()
        {
            try
            {
                var (IsSuccess, products) = await prod.GetProductAsync();

                if (IsSuccess)
                {
                    return Ok(products);
                }
                else
                {
                    return NotFound();
                }
           

            }


            catch(Exception e)
            {
                return NotFound();
            }
        }



    }
}
