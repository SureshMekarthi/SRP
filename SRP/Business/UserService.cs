using SRP.DBLayer;
using SRP.Interfaces;
using SRP.Models;
using System.Xml.Linq;

namespace SRP.Business
{
    public class UserService : IUserService
    {
        private IRepository userRepository;
        public UserService(IRepository userRepository) 
        {
            this.userRepository = userRepository;
        }
        public bool IsValidate(string name)
        {
            return true;
        }
        public bool UserCreation(User name)
        {
            if(IsValidate(name.Name))
            {
                userRepository.SaveUser(name);
                return true;
            }
            return false;
        }

        public string UserDetails(string id)
        {
              return userRepository.GetUser(id);
        }

    }
}
