using EP_Jewellery.Models;

namespace EP_Jewellery.Areas.Admin.Repository
{
    public interface IBrand
    {
        Task<BrandMst> GetByIdAsync(string id);
        Task<IEnumerable<BrandMst>> GetAllAsync();
        Task CreateAsync(BrandMst brand);
        Task UpdateAsync(BrandMst brand);
        Task DeleteAsync(string id);
    }
}
