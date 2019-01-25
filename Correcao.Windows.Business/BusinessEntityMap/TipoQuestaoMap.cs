using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correcao.Windows.Business.BusinessEntity;
using FluentNHibernate.Mapping;

namespace Correcao.Windows.Business.BusinessEntityMap
{
    public class TipoQuestaoMap : ClassMap<TipoQuestao>
    {
        public TipoQuestaoMap()
        {
            Id(x => x.IdTipoQuestao, "ID_TIPO_QUESTAO");            
            Map(x => x.Descricao, "DS_TIPO_QUESTAO");            
            Table("TIPO_QUESTAO");
        }
    }
}
