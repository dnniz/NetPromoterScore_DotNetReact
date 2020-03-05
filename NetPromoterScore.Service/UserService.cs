
using Microsoft.EntityFrameworkCore;
using NetPromoterScore.Data;
using NetPromoterScore.Entity;
using NetPromoterScore.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPromoterScore.Service
{
    public class UserService : IUserService
    {
        private readonly NetPromoterScoreContext _context;

        public UserService(NetPromoterScoreContext context) => _context = context;

        public async Task<User> AddAsync(User entity)
        {
            try
            {
                IRepository<User> rep = new EfRepository<User>(_context);
                entity.Password = SHAmanager.ManagerSHA256(entity.Password);
                await rep.InsertAsync(entity);

                return entity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<UserProfile>> GetAllProfilesAsync()
        {
            try
            {
                IRepository<UserProfile> rep = new EfRepository<UserProfile>(_context);

                return await rep.Table.Where(x => !x.FlagDeleted).ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }       
        }

        public async Task<User> LoginAsync(User entity)
        {
            try
            {
                IRepository<User> rep = new EfRepository<User>(_context);
                entity.Password = SHAmanager.ManagerSHA256(entity.Password);

                return await rep.Table.Where(x => x.UserName == entity.UserName && 
                                                      x.Password == entity.Password &&
                                                     !x.FlagDeleted
                                                ).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<User> UpdateAsync(User entity)
        {
            try
            {
                var rep = new EfRepository<User>(_context);
                await rep.UpdateAsync(entity);

                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
