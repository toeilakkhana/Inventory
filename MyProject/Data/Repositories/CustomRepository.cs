using Microsoft.AspNetCore.Mvc;
using MyProject.Data.Context;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }



    }
}
