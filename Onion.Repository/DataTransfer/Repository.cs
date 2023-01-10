using Microsoft.EntityFrameworkCore;
using Onion.Data.Common;
using Onion.Repository.ApplicationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repository.DataTransfer
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private OnionContext _context;
        private DbSet<TEntity> _dbSet;
        public Repository(OnionContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            IQueryable<TEntity> queryable = _dbSet;
            if (filter!=null)
            {
                queryable = queryable.Where(filter);
            }
            return queryable;
        }

        #region dispos
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity tentity)
        {
            _dbSet.Add(tentity);
        }

        public void Update(TEntity tentity)
        {
            _context.Entry(tentity).State = EntityState.Modified;
        }

        public void Delete(TEntity tentity)
        {
            _context.Entry(tentity).State = EntityState.Deleted;
        }


        #endregion
    }
}
