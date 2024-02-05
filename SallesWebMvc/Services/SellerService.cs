using Microsoft.EntityFrameworkCore;
using SallesWebMvc.Data;
using SallesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using SallesWebMvc.Services.Exceptions;
using System.Threading.Tasks;

namespace SallesWebMvc.Services
{
    public class SellerService
    {

        private readonly SallesWebMvcContext _context;

        public SellerService(SallesWebMvcContext context)
        {
            _context = context;
        }


        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async  Task<Seller> FindByIdAsync(int id)
        {
           return await _context.Seller.Include(obj => obj.Departament).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);

            }
        } 

        public async Task UpdateAsync(Seller obj)
        {
            bool asAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
           if (!asAny)
            {
                throw new NotFoundExceptions("Id não existe");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        
        }

    }
}
