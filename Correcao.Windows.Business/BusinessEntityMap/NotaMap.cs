using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correcao.Windows.Business.BusinessEntity;
using FluentNHibernate.Mapping;

namespace Correcao.Windows.Business.BusinessEntityMap
{
    public class NotaMap : ClassMap<Nota>
    {
        public NotaMap()
        {
            Id(x => x.IdNota, "ID_NOTA");            
            Map(x => x.Valor, "VL_NOTA");            
            Table("Notas");
        }
    }
}
