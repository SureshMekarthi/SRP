using SRP.Models;

namespace SRP.Interfaces
{
    public interface IRepository
    {
        string SaveUser(User user);
        string GetUser(string id);
    }
}
