using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject.Data.Context;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data.Repositories
{
    public class CollectProjectRepository : GenericRepository<CollectProject>
    {
        private readonly ApplicationDbContext _context;
        public CollectProjectRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
