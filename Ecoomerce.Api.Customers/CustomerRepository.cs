using AutoMapper;
using Ecoomerce.Api.Customers.DB;
using Ecoomerce.Api.Customers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoomerce.Api.Customers
{
    public class CustomerRepository:ICustomer
    {
        private readonly CustomerDbContext _dbContext;
        private readonly IMapper _mapper;
        public CustomerRepository(CustomerDbContext dbContext,  IMapper mapper)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;

            SeedData();
        }

        private void SeedData()
        {
            if (!_dbContext.customers.Any())
            {
                _dbContext.customers.Add(new DB.Customer
                {
                    Id = 1,
                    Name = "Tom",
                    Address = "India"
                });

                _dbContext.customers.Add(new DB.Customer
                {
                    Id = 2,
                    Name = "Harry",
                    Address = "NY"
                });

                _dbContext.customers.Add(new DB.Customer
                {
                    Id = 3,
                    Name = "Sally",
                    Address = "France"
                });
                _dbContext.SaveChanges();
            }
        }

        public async Task<(bool IsSuccess, IEnumerable<Models.Customer> customers)> GetCustomerAsync()
        {
            try
            {

                var results = await _dbContext.customers.ToListAsync();
                if (results != null)
                {
                    var resultList = _mapper.Map
                   <IEnumerable<DB.Customer>, IEnumerable<Models.Customer>>(results);
                    return (true, resultList);
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
    }
}
