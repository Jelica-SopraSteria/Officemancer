﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Officemancer.Services
{
    public class AdminService : IAdminService
    {
        private readonly MancerContext _context;

        public AdminService(MancerContext context)
        {
            _context = context;
        }

        
    }
}