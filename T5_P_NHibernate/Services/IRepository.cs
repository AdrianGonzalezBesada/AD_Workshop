using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_P_NHibernate.Services
{
    internal interface IRepository<TEntity, TKey> where TEntity : class
    {
        TKey Save(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        TEntity GetById(TKey id);

        List<TEntity> GetAll();

    }
}
