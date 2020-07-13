using Ecoomerce.Api.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoomerce.Api.Search
{
  public  interface IproductService
    {
        Task<(bool IsSuccess, IEnumerable<Product> products)> GetProductAsync();
    }
}
