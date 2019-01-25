using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correcao.Windows.Business.BusinessEntity;
using FluentNHibernate.Mapping;

namespace Correcao.Windows.Business.BusinessEntityMap
{
    public class QuestaoMap : ClassMap<Questao>
    {
        public QuestaoMap()
        {
            Table("Questao");
            Id(x => x.IdQuestao, "ID_QUESTAO").GeneratedBy.Identity();            
            Map(x => x.Descricao, "DS_QUESTAO");
            References(x => x.TipoQuestao).Column("ID_TIPO_QUESTAO").Fetch.Join().Not.LazyLoad();                    
        }
    }
}
