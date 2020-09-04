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

        Task AddAsync(T entity);

        Task RemoveAsync(T entity);

        Task UpdateAsync(T entity);
    }
}
