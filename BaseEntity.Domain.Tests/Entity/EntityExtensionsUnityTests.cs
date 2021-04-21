using BaseEntity.Domain.Tests.Shared;
using System;
using Xunit;
using BaseEntity.Domain.Entities.Extensions;
using FluentAssertions;

namespace BaseEntity.Domain.Tests.Entity
{
    public class EntityExtensionsUnityTests : BaseMock
    {
        [Fact]
        public void SetId_ShouldUpdateEntityId()
        {
            var anyEntity = AnyClassFake();
            const int id = 1;

            anyEntity.SetId(id);

            anyEntity.Id.Should().Be(id);
        }

        [Fact]
        public void SetCreatedAt_ShouldUpdateCreatedAt()
        {
            var anyEntity = AnyClassFake();

            anyEntity.SetCreatedAt(DateTime.Now);

            anyEntity.CreatedAt.Should().BeCloseTo(DateTime.Now, 500);
        }

        [Fact]
        public void SetLastUpdate_ShouldUpdateLastUpdate()
        {
            var anyEntity = AnyClassFake();

            anyEntity.SetLastUpdate(DateTime.Now);

            anyEntity.CreatedAt.Should().BeCloseTo(DateTime.Now, 500);
        }
    }
}
