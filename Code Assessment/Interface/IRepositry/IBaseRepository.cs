using System.Linq.Expressions;

namespace Code_Assessment.Interface.IRepositry
{
    public interface IBaseRepository<T>
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        Task<int> SaveAsync();
        Task<bool> CheckExit(Expression<Func<T, bool>> expression);
    }
}
