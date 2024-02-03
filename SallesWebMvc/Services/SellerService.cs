using SallesWebMvc.Data;
using SallesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace SallesWebMvc.Services
{
    public class SellerService
    {

        private readonly SallesWebMvcContext _context;

        public SellerService(SallesWebMvcContext context)
        {
            _context = context;
        }


        public List<Seller> findAll()
        {
            return _context.Seller.ToList();
        }

    }
}
