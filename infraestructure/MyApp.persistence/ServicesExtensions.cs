using cleanarchteture.domain.entities;
using cleanarchteture.domain.interfaces;
using Microsoft.Extensions.Options;

namespace cleanarchteture.persistence
{
    public static class ServicesExtensions
    {
        public static void ConfigurePersistenceApp(this IUserRepository userRepository, IConfigureOptions<User> configureOptions)
        {
            var connectionString = configureOptions.get
        }
    }
}