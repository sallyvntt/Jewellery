using EP_Jewellery.Models;

namespace EP_Jewellery.Areas.Admin.Repository
{
    public interface IBrand
    {
        BrandMst GetById(string id);
        IEnumerable<BrandMst> GetAll();
        void Create(BrandMst brand);
        void Update(BrandMst brand);
        void Delete(string id);
    }
}
