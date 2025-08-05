using cleanarchteture.domain.entities;
using cleanarchteture.domain.interfaces;
using cleanarchteture.persistence.context;

namespace cleanarchteture.persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();  
        } 

    }
}