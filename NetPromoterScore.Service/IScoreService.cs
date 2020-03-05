using NetPromoterScore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetPromoterScore.Service
{
    public interface IScoreService
    {
        public abstract Task<Score> AddAsync(Score entity);
        public abstract Task<List<Score>> GetListScoreByCompanyAsync();
        
    }
}
