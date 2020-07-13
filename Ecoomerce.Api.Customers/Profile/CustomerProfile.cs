﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecoomerce.Api.Customers.Profile
{
    public class CustomerProfile: AutoMapper.Profile
    {
        public CustomerProfile()
        {
            CreateMap<DB.Customer, Models.Customer>();
        }

    }
}
