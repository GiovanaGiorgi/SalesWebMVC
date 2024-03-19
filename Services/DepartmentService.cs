using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebAppMvc.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebAppMvc.Services
{

    public class DepartmentService
    {
        private readonly SalesWebAppMvcContext _context;

        public DepartmentService(SalesWebAppMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}