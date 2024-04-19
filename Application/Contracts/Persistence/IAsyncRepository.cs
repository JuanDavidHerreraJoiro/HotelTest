using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T :class
    {

        Task<T> AddAsync(T entity);
        Task RemoveAsync(T entity);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetTypeStateAsync(Expression<Func<T,bool>> expression);
    }
}
