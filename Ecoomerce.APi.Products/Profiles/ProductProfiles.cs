using Ecoomerce.APi.Products.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecoomerce.APi.Products.Models;

namespace Ecoomerce.APi.Products.Profiles
{
    public class ProductProfiles:AutoMapper.Profile
    {
        public ProductProfiles()
        {

            CreateMap<DB.Product, Models.Product>();
        }
    }
}
