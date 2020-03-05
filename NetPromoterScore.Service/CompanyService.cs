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
    public class CompanyService : ICompanyService
    {
        private readonly NetPromoterScoreContext _context;

        public CompanyService(NetPromoterScoreContext context) => _context = context;
        public async Task<Company> GetPrincipalCompany()
        {
            try
            {
                IRepository<Company> rep = new EfRepository<Company>(_context);

                return await rep.Table.Where(x => !x.FlagDeleted).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
