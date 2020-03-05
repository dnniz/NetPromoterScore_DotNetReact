using Microsoft.EntityFrameworkCore;
using NetPromoterScore.Data;
using NetPromoterScore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPromoterScore.Service
{
    public class ScoreService : IScoreService
    {
        private readonly NetPromoterScoreContext _context;

        public ScoreService(NetPromoterScoreContext context) => _context = context;
        public async Task<Score> AddAsync(Score entity)
        {
            try
            {
                IRepository<Score> rep = new EfRepository<Score>(_context);
                await rep.InsertAsync(entity);

                return entity;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<Score>> GetListScoreByCompanyAsync()
        {
            try
            {
                IRepository<Company> rep = new EfRepository<Company>(_context);

                var result = await rep.Table.Where(x => !x.FlagDeleted)
                                .Include(x => x.ListScore)
                                .ThenInclude(x => x.User)
                                .Select(x => x.ListScore)
                                .SingleOrDefaultAsync();

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
