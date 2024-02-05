using Microsoft.EntityFrameworkCore;
using SallesWebMvc.Data;
using SallesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Services
{
    public class DepartamentService
    {
        private readonly SallesWebMvcContext _context;

        public DepartamentService(SallesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x=> x.Name).ToListAsync();
        }


    }
}
