using NetPromoterScore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetPromoterScore.Service
{
    public interface ICompanyService
    {
        public abstract Task<Company> GetPrincipalCompany();
        
    }
}
