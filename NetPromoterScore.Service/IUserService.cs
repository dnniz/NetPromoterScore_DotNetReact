using NetPromoterScore.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetPromoterScore.Service
{
    public interface IUserService
    {
        public abstract Task<IEnumerable<UserProfile>> GetAllProfilesAsync();
        public abstract Task<User> AddAsync(User entity);
        public abstract Task<User> UpdateAsync(User entity);
        public abstract Task<User> LoginAsync(User entity);

        

    }
}
