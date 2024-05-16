using Code_Assessment.Models;
using System.Linq.Expressions;

namespace Code_Assessment.Interface.IRepositry
{
    public interface IUserRepository
    {

        Task<UserRoles> LoginAsync(string email, string password);
        Task<List<UserRoles>> GetUserByRoleAsync(string role);
        Task<UserRoles> GetAsync(Expression<Func<UserRoles, bool>> expression);
    }
}
