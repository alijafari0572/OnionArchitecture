using Onion.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repository.DataTransfer
{
    public interface IRepository<TEntity>:IDisposable where TEntity : BaseEntity
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity,bool>>filter);
        void Insert(TEntity tentity);
        void Update(TEntity tentity);
        void Delete(TEntity tentity);
    }
}
