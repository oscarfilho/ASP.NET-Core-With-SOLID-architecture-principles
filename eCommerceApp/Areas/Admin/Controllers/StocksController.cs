﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eCommerce.DatabaseContext;
using eCommerceApp.Models;

namespace eCommerceApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StocksController : Controller
    {
        private readonly DatabaseDbContext _context;

        public StocksController(DatabaseDbContext context)
        {
            _context = context;
        }
    }
}