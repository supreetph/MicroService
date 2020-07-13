using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoomerce.Api.Search
{
    public class SearchRepository : ISearch
    {
        public Task<(bool isSuccess, dynamic CustomerSearchResult)> SearchAsync(int CustomerID)
        {
            return (true, new { message= "jzdhjfahd" });
        }
    }
}
