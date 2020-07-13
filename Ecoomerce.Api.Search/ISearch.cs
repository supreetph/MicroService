using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Ecoomerce.Api.Search
{
   public interface ISearch
    {
     public  Task<(bool isSuccess, dynamic CustomerSearchResult)> SearchAsync(int CustomerID);
    }
}
