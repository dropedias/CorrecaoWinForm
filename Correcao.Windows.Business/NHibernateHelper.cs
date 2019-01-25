using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Correcao.Windows.Business.BusinessEntity;
using Correcao.Windows.Business.BusinessEntityMap;

namespace Correcao.Windows.Business
{
    public class NHibernateHelper
    {
        public static ISession OpenSession() 
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                  .ConnectionString(@"Server=PEDRO-NOTEBOOK\SQLEXPRESS;initial catalog=Cesgrario;integrated security=True;MultipleActiveResultSets=True;")
                    .ShowSql()
                )
               //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<Imagem>())
               .Mappings(m => m.FluentMappings.Add<ImagemMap>())
               .Mappings(m => m.FluentMappings.Add<CandidatoMap>())
               .Mappings(m => m.FluentMappings.Add<TipoQuestaoMap>())
               .Mappings(m => m.FluentMappings.Add<NotaMap>())               
               .Mappings(m => m.FluentMappings.Add<QuestaoMap>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                .Create(false, false))
                .BuildSessionFactory();

            return sessionFactory.OpenSession();
        }
    }
}
