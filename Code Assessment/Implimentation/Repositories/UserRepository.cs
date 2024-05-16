using Code_Assessment.Context;
using Code_Assessment.Interface.IRepositry;
using Code_Assessment.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

namespace Code_Assessment.Implimentation.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<UserRoles> GetAsync(Expression<Func<UserRoles, bool>> expression)
        {

            var get = await _context.UserRoles
            .Include(u => u.Role)
            .Include(u => u.User)
            .SingleOrDefaultAsync(expression);
            return get;
        }

        public async Task<List<UserRoles>> GetUserByRoleAsync(string role)
        {
            return await _context.UserRoles
            .Where(x => x.Role.Name == role && x.Role.IsDeleted == false && x.User.IsDeleted == false)
            .Include(c => c.User)
            .Include(c => c.Role)
            .ToListAsync();
        }

        public async Task<UserRoles> LoginAsync(string email, string password)
        {
            return await _context.UserRoles
            .Where(c => c.User.Email == email && c.User.Password == password && c.User.IsDeleted == false)
            .Include(c => c.Role)
            .Include(x => x.User)
            .SingleOrDefaultAsync();
        }
    }
}
