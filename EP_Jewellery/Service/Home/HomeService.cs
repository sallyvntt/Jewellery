using EP_Jewellery.Models;
using EP_Jewellery.Repository.Home;
using Microsoft.EntityFrameworkCore;

namespace EP_Jewellery.Service.Home
{
    public class HomeService : IHome
    {
        private readonly DatabaseContext db;

        public HomeService(DatabaseContext db) { this.db = db; }
        public async Task<bool> Login(string username, string password)
        {
            var acc = await db.Admin.SingleOrDefaultAsync(a => a.username.Equals(username));
            if (acc == null)
            {
                var acc1 = await db.User.SingleOrDefaultAsync(a1 => a1.userId.Equals(username));
                if (acc1 == null)
                {
                    return false;
                }
                else
                {
                    if (acc1.password.Equals(password))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (acc.password.Equals(password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> Register(User newUser)
        {
            db.User.Add(newUser);
            return true;
        }
    }
}
