using cleanarchteture.domain.entities;

namespace cleanarchteture.domain.interfaces
{
    public interface IBaseRespository<T> where T : BaseEntity
    {
        void create(T entity);
        void update(T entity);
        void delete(T entity);
        Task<T> Get(Guid Id, CancellationToken cancellationToken);
        Task<T>  GetAll (CancellationToken cancellationToken);
    }
}