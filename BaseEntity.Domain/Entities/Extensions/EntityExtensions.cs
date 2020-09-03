using System;

namespace BaseEntity.Domain.Entities.Extensions
{
    public static class EntityExtensions
    {
        public static TEntity SetId<TEntity>(this TEntity entity, long id) where TEntity : Entity
        {
            entity.Id = id;
            return entity;
        }

        public static TEntity SetCreatedAt<TEntity>(this TEntity entity, DateTime createdAt) where TEntity : Entity
        {
            entity.CreatedAt = createdAt;
            return entity;
        }

        public static TEntity SetLastUpdate<TEntity>(this TEntity entity, DateTime lastUpdate) where TEntity : Entity
        {
            entity.LastUpdate = lastUpdate;
            return entity;
        }
    }
}
