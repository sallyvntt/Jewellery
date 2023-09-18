using EP_Jewellery.Models;

namespace EP_Jewellery.Repository.Home
{
    public interface IHome
    {
        Task<bool> Login(string username, string password);
        Task<bool> Register(User newUser);
    }
}
