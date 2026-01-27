using SRP.Interfaces;
using SRP.Models;

namespace SRP.DBLayer
{
    public class UserRepository: IRepository
    {

        public string SaveUser(User user)
        {
            return "Data is saved";
        }
        public string GetUser(string id)
        {
            return "testuser";
        }
    }
}
