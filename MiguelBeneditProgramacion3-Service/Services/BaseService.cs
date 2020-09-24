using MiguelBeneditProgramacion3_Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiguelBeneditProgramacion3_Service.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity: class
    {
        ///<inheritdoc cref="IBaseService{TEntity}"/>
        public virtual Task CreateAsync(TEntity value, string userName)
        {
            throw new System.NotImplementedException();
        }

        ///<inheritdoc cref="IBaseService{TEntity}"/>
        public virtual Task DeleteAsync(long Id)
        {
            throw new System.NotImplementedException();
        }

        ///<inheritdoc cref="IBaseService{TEntity}"/>
        public virtual Task<IEnumerable<TEntity>> GetAsync()
        {
            throw new System.NotImplementedException();
        }

        ///<inheritdoc cref="IBaseService{TEntity}"/>
        public virtual Task<TEntity> GetAsync(long Id)
        {
            throw new System.NotImplementedException();
        }

        ///<inheritdoc cref="IBaseService{TEntity}"/>
        public virtual Task UpdateAsync(long Id, TEntity value, string userName)
        {
            throw new System.NotImplementedException();
        }
    }
}
