using System;

namespace BaseEntity.Domain.Tests.Shared
{
    public class BaseMock
    {
        public class AnyClass : Entities.Entity
        {
            public AnyClass(int anyNumber, string anyProperty)
                :base(Guid.NewGuid())
            {
                AnyNumber = anyNumber;
                AnyProperty = anyProperty;
            }

            public int AnyNumber { get; set; }

            public string AnyProperty { get; set; }
        }

        public AnyClass AnyClassFake(int? anyNumber = null, string anyProperty = null)
            => new AnyClass(anyNumber ?? 333, anyProperty ?? string.Empty);
    }
}
