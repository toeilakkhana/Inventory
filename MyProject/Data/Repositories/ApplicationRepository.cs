using Microsoft.AspNetCore.Mvc;
using MyProject.Data.Context;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data.Repositories
{
    public class ApplicationRepository : GenericRepository<Application>
    {
        private readonly ApplicationDbContext _context;


        public ApplicationRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }



    }
}
