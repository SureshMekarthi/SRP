using SRP.Models;

namespace SRP.Business
{
    public interface IUserService
    {
        public bool UserCreation(User name);
        public bool IsValidate(string name);
        public string UserDetails(string id);
    }
}
