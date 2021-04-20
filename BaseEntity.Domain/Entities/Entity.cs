using System;

namespace BaseEntity.Domain.Entities
{
    public abstract class Entity
    {
        #region Constants

        protected const string ConstructorObsoleteMessage = "Created only for EF";

        #endregion

        #region Properties

        public long Id { get; internal set; }

        public Guid Code { get; protected set; } = Guid.NewGuid();

        public DateTime CreatedAt { get; internal set; } = DateTime.Now;

        public DateTime LastUpdate { get; internal set; } = DateTime.Now;

        public DateTime? DeletedAt { get; private set; }

        public bool Deleted => DeletedAt.HasValue;

        #endregion

        #region Constructors

        [Obsolete(ConstructorObsoleteMessage, true)]
        protected Entity() { }

        protected Entity(Guid code)
        {
            Code = code;
        }

        #endregion

        #region Methods

        public void Delete()
        {
            DeletedAt = DateTime.Now;
            LastUpdate = DateTime.Now;
        }

        public void UpdateLastUpdatedDate() => LastUpdate = DateTime.Now;

        #endregion
    }
}
