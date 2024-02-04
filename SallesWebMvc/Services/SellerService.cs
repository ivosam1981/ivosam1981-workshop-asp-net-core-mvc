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


        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public Seller FindById(int id)
        {
           return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        } 

    }
}
