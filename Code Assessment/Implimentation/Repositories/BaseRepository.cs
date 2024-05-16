using Code_Assessment.Context;
using Code_Assessment.Interface.IRepositry;
using Code_Assessment.Models;
using System.Linq.Expressions;

namespace Code_Assessment.Implimentation.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public Task<bool> CheckExit(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return entity;
        }

        public async  Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<T> Update(T entity)
        {
             await _context.SaveChangesAsync();
            return entity;
        }
    }
}
