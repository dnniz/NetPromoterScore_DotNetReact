using Microsoft.EntityFrameworkCore;
using NetPromoterScore.Entity;
using NetPromoterScore.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetPromoterScore.Data
{
    public class NetPromoterScoreContext : DbContext, IDbContext
    {
        public NetPromoterScoreContext(DbContextOptions<NetPromoterScoreContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed
            var seed = SeedData();
            seed.TryGetValue(DictionaryKey.Company, out var lstCompany);
            seed.TryGetValue(DictionaryKey.UserProfile, out var lstUserProfile);
            seed.TryGetValue(DictionaryKey.UserType, out var lstUserType);
            #endregion

            modelBuilder.Entity<User>();
            modelBuilder.Entity<Company>().HasData(lstCompany);
            modelBuilder.Entity<Score>();
            modelBuilder.Entity<UserProfile>().HasData(lstUserProfile);
            modelBuilder.Entity<UserType>().HasData(lstUserType);

            base.OnModelCreating(modelBuilder);
        }

        
        public new DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        #region Seed DATA
        public Dictionary<DictionaryKey, List<BaseEntity>> SeedData()
        {
            var dictionary = new Dictionary<DictionaryKey, List<BaseEntity>>();

            var lstUserProfile = new List<BaseEntity>();
            var lstUserType = new List<BaseEntity>();
            var lstCompany = new List<BaseEntity>();

            lstCompany.Add(new Company() { Name = "Service Company SAC", CompanyId = 1 });
            lstUserProfile.Add(new UserProfile() { Description = Complement.GetEnumDescription(UserProfiles.Administrador), UserProfileId = (int)UserProfiles.Administrador });
            lstUserProfile.Add(new UserProfile() { Description = Complement.GetEnumDescription(UserProfiles.Votante), UserProfileId = (int)UserProfiles.Votante });
            lstUserType.Add(new UserType() { Description = Complement.GetEnumDescription(UserTypes.Detractor), UserTypeId = (int)UserTypes.Detractor });
            lstUserType.Add(new UserType() { Description = Complement.GetEnumDescription(UserTypes.Neutro), UserTypeId = (int)UserTypes.Neutro });
            lstUserType.Add(new UserType() { Description = Complement.GetEnumDescription(UserTypes.Promotor), UserTypeId = (int)UserTypes.Promotor });

            dictionary.Add(DictionaryKey.Company, lstCompany);
            dictionary.Add(DictionaryKey.UserProfile, lstUserProfile);
            dictionary.Add(DictionaryKey.UserType, lstUserType);

            return dictionary;
        }
        #endregion
    }
}
