using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correcao.Windows.Business.BusinessEntity;
using NHibernate;

namespace Correcao.Windows.Business
{
    public class QuestaoBO
    {
        public IList<Questao> GetQuestoes()
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())   
                {
                    var questoes = session.Query<Questao>().ToList();

                    return questoes;
                }                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
