using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Mapping.Attributes;
using NHibernate.Cfg;
using System.Reflection;
using T5_P_NHibernate.Entities;
//using Clase Entidades;

namespace T5_P_NHibernate.Configurations
{
    public class NHibernateUtil
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory GetISessionFactory()
        {
            if (_sessionFactory == null)
            {
                return BuildSessionFactory();
            }else
            {
                return _sessionFactory;
            }
        }

        private static ISessionFactory BuildSessionFactory()
        {
            try
            {
                if (_sessionFactory == null)
                {
                    Configuration config = new Configuration();
                    config.Configure();

                    HbmSerializer.Default.Validate = true;
                    config.AddInputStream(HbmSerializer.Default.Serialize(Assembly.GetExecutingAssembly()));

                    config.AddAssembly(typeof(Asignatura).Assembly);
                    config.AddAssembly(typeof(Instituto).Assembly);
                    config.AddAssembly(typeof(Estudiante).Assembly);

                    new SchemaUpdate(config);

                    _sessionFactory = config.BuildSessionFactory();
                }
                return _sessionFactory;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void Start()
        {
            BuildSessionFactory();
        }
        public static void Stop()
        {
            GetISessionFactory().Close();
        }
    }
}
