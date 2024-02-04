using SallesWebMvc.Data;
using SallesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SallesWebMvc.Services
{
    public class DepartamentService
    {
        private readonly SallesWebMvcContext _context;

        public DepartamentService(SallesWebMvcContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x=> x.Name).ToList();
        }


    }
}
