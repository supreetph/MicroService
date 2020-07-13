using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoomerce.Api.Search
{
    public class SearchRepository : ISearch
    {
        private readonly IproductService _iproductService;
        public SearchRepository(IproductService iproductService)
        {
            this._iproductService = iproductService;

        }
        public async Task<(bool isSuccess, dynamic CustomerSearchResult)> SearchAsync(int CustomerID)
        {
            var result = await _iproductService.GetProductAsync();
            return (true, result.products);
        }
    }
}
