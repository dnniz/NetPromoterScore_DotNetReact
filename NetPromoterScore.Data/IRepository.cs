using NetPromoterScore.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace NetPromoterScore.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        ValueTask<T> GetByIdAsync(object id);
        ValueTask<int> InsertAsync(T entity);
        ValueTask<int> UpdateAsync(T entity);
        ValueTask<int> DeleteAsync(T entity);
        IQueryable<T> Table { get; }
    }
}
