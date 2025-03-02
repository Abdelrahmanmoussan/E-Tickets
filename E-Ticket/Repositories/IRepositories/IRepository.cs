using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;


namespace E_Ticket.Repositories.IRepositories
{
    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> Get(Expression<Func<T, bool>>? filter = null, Expression<Func<T, object>>[]? includes = null, bool tracked = true);

        public T? GetOne(Expression<Func<T, bool>>? filter = null, Expression<Func<T, object>>[]? includes = null, bool tracked = true);


    }
}
