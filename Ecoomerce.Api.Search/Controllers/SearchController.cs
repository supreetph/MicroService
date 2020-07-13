using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecoomerce.Api.Search.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecoomerce.Api.Search.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearch _search;
        public SearchController(ISearch search)
        {
           this._search = search;
        }

        public async Task<IActionResult> SearchCustomerAysnc(SearchCriteria criteria)
        {
            var result = await _search.SearchAsync(criteria.CustomerId);
            if(result.isSuccess)
            {
                return Ok( (true, result));
            }
            else
            {
                return NotFound();
            }
        }
    }
}
