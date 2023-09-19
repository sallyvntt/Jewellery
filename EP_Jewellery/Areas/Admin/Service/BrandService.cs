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

        public BrandMst GetById(string id)
        {
            return _context.BrandMsts.Find(id);
        }

        public IEnumerable<BrandMst> GetAll()
        {
            return _context.BrandMsts.ToList();
        }

        public void Create(BrandMst brand)
        {
            _context.BrandMsts.Add(brand);
            _context.SaveChanges();
        }

        public void Update(BrandMst brand)
        {
            _context.BrandMsts.Update(brand);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var brand = _context.BrandMsts.Find(id);
            if (brand != null)
            {
                _context.BrandMsts.Remove(brand);
                _context.SaveChanges();
            }
        }
    }
}
