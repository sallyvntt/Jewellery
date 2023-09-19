using EP_Jewellery.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EP_Jewellery.Areas.Admin.Repository
{
    public interface ICat
    {
        Task<IEnumerable<CatMst>> GetAllAsync();
        Task<CatMst> GetByIdAsync(string id);
        Task CreateAsync(CatMst cat);
        Task UpdateAsync(CatMst cat);
        Task DeleteAsync(string id);
    }
}
