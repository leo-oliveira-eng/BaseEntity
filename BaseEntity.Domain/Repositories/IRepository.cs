using BaseEntity.Domain.Entities;
using Messages.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BaseEntity.Domain.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<List<T>> GetAllAsync();

        Task<Maybe<T>> FindAsync(Guid code);

        Task<List<T>> FindAsync(List<Guid> codes);

        Task AddAsync(T entity);

        Task AddAsync(List<T> entities);

        Task RemoveAsync(T entity);

        Task RemoveAsync(List<T> entities);

        Task UpdateAsync(T entity);

        Task UpdateAsync(List<T> entities);
    }
}
