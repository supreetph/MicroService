using Ecoomerce.APi.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoomerce.APi.Products
{
  public  interface Iproduct
    {
       public  Task<(bool IsSuccess, IEnumerable<Product> products)> GetProductAsync();
    }
}
