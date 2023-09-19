using EP_Jewellery.Areas.Admin.Repository;
using EP_Jewellery.Models;
using Microsoft.EntityFrameworkCore;

namespace EP_Jewellery.Areas.Admin.Service
{
    public class BrandService : IBrand
    {
        private readonly JeweDBContext _context;

        public BrandService(JeweDBContext context)
        {
            _context = context;
        }

        public async Task<BrandMst> GetByIdAsync(string id)
        {
            return await _context.BrandMsts.FindAsync(id);
        }

        public async Task<IEnumerable<BrandMst>> GetAllAsync()
        {
            return await _context.BrandMsts.ToListAsync();
        }

        public async Task CreateAsync(BrandMst brand)
        {
            _context.BrandMsts.Add(brand);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(BrandMst brand)
        {
            _context.BrandMsts.Update(brand);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var brand = await _context.BrandMsts.FindAsync(id);
            if (brand != null)
            {
                _context.BrandMsts.Remove(brand);
                await _context.SaveChangesAsync();
            }
        }
    }

}
