using NHibernate;
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
        protected NHibernate.ISession GetISession()
        {
            return (NHibernate.ISession)Configurations.NHibernateUtil.GetISessionFactory().OpenSession();
        }

        public TKey Save(TEntity entity)
        {
            NHibernate.ISession sesion = this.GetISession();
            ITransaction tx = sesion.BeginTransaction();

            try
            {
                TKey tKey = (TKey)sesion.Save(entity);
                tx.Commit();
                sesion.Close();
                return tKey;
            }
            catch (Exception ex)
            {
                tx.Rollback();
                sesion.Close();
                throw;
            }
        }

        public void Update(TEntity entity)
        {
            NHibernate.ISession sesion = this.GetISession();
            ITransaction tx = sesion.BeginTransaction();

            try
            {
                sesion.Update(entity);
                tx.Commit();
                sesion.Close();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                sesion.Close();
                throw;
            }
        }

        public void Delete(TEntity entity)
        {
            NHibernate.ISession sesion = this.GetISession();
            ITransaction tx = sesion.BeginTransaction();

            try
            {
                sesion.Delete(entity);
                tx.Commit();
                sesion.Close();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                sesion.Close();
                throw;
            }
        }

        public List<TEntity> GetAll()
        {
            NHibernate.ISession session = this.GetISession();
            List<TEntity> lista = session.Query<TEntity>().ToList();
            session.Close();
            return lista;
        }

        public TEntity GetById(TKey id)
        {
            NHibernate.ISession sesion = this.GetISession();
            TEntity entity = sesion.Get<TEntity>(id);
            return entity;
        }
    }
}
