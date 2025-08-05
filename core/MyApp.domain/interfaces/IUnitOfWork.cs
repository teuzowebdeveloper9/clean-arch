using cleanarchteture.domain.entities;

namespace cleanarchteture.domain.interfaces
{
    internal interface IUnitOfWork
    {
        Task Commit(CancellationToken cancellationToken);
    }
}