using AutoMapper;
using Ecoomerce.APi.Products.DB;
using Ecoomerce.APi.Products.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoomerce.APi.Products
{
    public class ProductRespository : Iproduct
    {
        private readonly ProductDBContext _dbcontext;
        private readonly IMapper mapper;
        public ProductRespository(ProductDBContext dbContext,IMapper mapper)
        {
            this._dbcontext = dbContext;
            this.mapper = mapper;

            SeedData();

        }

        public async Task<(bool, IEnumerable<Models.Product>)> GetProductAsync()
        {
            try
            {
                var results = await _dbcontext.products.ToListAsync();
                if (results != null)
                {
                    var resultsList = mapper.Map<IEnumerable<DB.Product>, IEnumerable<Models.Product>>(results);
                    return (true, resultsList);
                }
                else
                {
                    return (false, null);
                }
               
            
            }
            catch (Exception e)
            {
                throw e;
               
            }
        }

        public void SeedData()
        {
            if (!_dbcontext.products.Any())
            {
                _dbcontext.products.Add(new DB.Product
                {
                    id = 1,
                    Name = "Mobile",
                    Cost = 2000
                }



                    ); ;

                _dbcontext.products.Add(new DB.Product
                {
                    id = 2,
                    Name = "TV",
                    Cost = 20000
                }



                   ); ;

                _dbcontext.products.Add(new DB.Product
                {
                    id = 3,
                    Name = "Laptop",
                    Cost = 30000
                }



                   ); ;
                _dbcontext.SaveChanges();
                
            }
            

        }
     

       
    }
}
