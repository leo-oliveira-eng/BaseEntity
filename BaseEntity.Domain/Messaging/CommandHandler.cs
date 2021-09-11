using BaseEntity.Domain.UnitOfWork;
using Messages.Core;
using Messages.Core.Extensions;
using System;
using System.Threading.Tasks;

namespace BaseEntity.Domain.Messaging
{
    public abstract class CommandHandler
    {
        IUnitOfWork UnitOfWork { get; }

        protected CommandHandler(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        protected async Task<Response> CommitAsync()
        {
            var response = Response.Create();

            if (!await UnitOfWork.CommitAsync())
                response.WithCriticalError("Failed to commit data");

            return response;
        }
    }
}
