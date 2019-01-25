using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correcao.Windows.Business.BusinessEntity;
using NHibernate;

namespace Correcao.Windows.Business
{
    public class ImagemBO
    {
        public void InserirImagem(Imagem imagem)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())   
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(imagem);
                        transaction.Commit();
                    }
                }                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Imagem GetImagem(int idImagem)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    var imagem = session.Get<Imagem>(idImagem);

                    return imagem;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }   
    }
}
