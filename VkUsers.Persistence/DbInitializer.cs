﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkUsers.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(UserDbContext userDbContext)
        {
            userDbContext.Database.EnsureCreated();
        }
    }
}
