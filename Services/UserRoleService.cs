using Repositories;
using Repositories.Entities;

namespace Services
{
    public class UserRoleService
    {
        UserRoleRepository _repo = new UserRoleRepository();
        public UserRole? CheckLogin(string username, string password)
        {
            return _repo.GetAccount(username, password);
        }
    }
}
