using cleanarchteture.domain.entities;
using cleanarchteture.domain.interfaces;
using cleanarchteture.persistence.context;

namespace cleanarchteture.persistence.Repositories
{
    public class BaseRepository<T> : IBaseRespository<T> where T : BaseEntity

    {

        protected readonly AppDbContext Context;

        public BaseRepository(AppDbContext context)
        {
            Context = context;
        }


        public void create(T entity)
        {
            throw new NotImplementedException();
        }

        public void delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(Guid Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}