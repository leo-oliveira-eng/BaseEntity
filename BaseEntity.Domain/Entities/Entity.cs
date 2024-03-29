﻿using BaseEntity.Domain.Events;
using System;
using System.Collections.Generic;

namespace BaseEntity.Domain.Entities
{
    public abstract class Entity
    {
        #region Constants

        protected const string ConstructorObsoleteMessage = "Only for Entity Framework";

        #endregion

        #region Fields

        private readonly List<DomainEvent> _domainEvents = new List<DomainEvent>();

        #endregion

        #region Properties

        public long Id { get; internal set; }

        public Guid Code { get; protected set; } = Guid.NewGuid();

        public DateTime CreatedAt { get; internal set; } = DateTime.Now;

        public DateTime LastUpdate { get; internal set; } = DateTime.Now;

        public DateTime? DeletedAt { get; private set; }

        public bool Deleted => DeletedAt.HasValue;

        public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

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

        public void AddDomainEvent(DomainEvent domainEvent) => _domainEvents.Add(domainEvent);

        public void RemoveDomainEvent(DomainEvent domainEvent) => _domainEvents.Remove(domainEvent);

        public void ClearDomainEvents() => _domainEvents?.Clear();

        #endregion
    }
}
