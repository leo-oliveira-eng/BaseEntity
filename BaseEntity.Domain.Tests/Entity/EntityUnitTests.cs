using BaseEntity.Domain.Tests.Shared;
using FluentAssertions;
using System;
using Xunit;

namespace BaseEntity.Domain.Tests.Entity
{
    public class EntityUnitTests : BaseMock
    {
        [Fact]
        public void DeleteEntity_ShoudUpdateDeletedAtAndLastUpdate()
        {
            var anyEntity = AnyClassFake();

            anyEntity.Delete();

            anyEntity.DeletedAt.Should().NotBeNull();
            anyEntity.Deleted.Should().BeTrue();
            anyEntity.DeletedAt.Should().BeCloseTo(DateTime.Now, 500);
            anyEntity.LastUpdate.Should().BeCloseTo(DateTime.Now, 500);
        }

        [Fact]
        public void UpdateLastUpdateDate_ShoudUpdateLastUpdate()
        {
            var anyEntity = AnyClassFake();

            anyEntity.UpdateLastUpdatedDate();

            anyEntity.DeletedAt.Should().BeNull();
            anyEntity.Deleted.Should().BeFalse();
            anyEntity.LastUpdate.Should().BeCloseTo(DateTime.Now, 500);
        }
    }
}
