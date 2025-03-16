using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace T5_P_NHibernate.Services
{
    public class IRepositoryImpl<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        protected ISession GetISession()
        {
            return (ISession)Configurations.NHibernateUtil.GetISessionFactory().OpenSession();
        }

        public TKey Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(TKey id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
