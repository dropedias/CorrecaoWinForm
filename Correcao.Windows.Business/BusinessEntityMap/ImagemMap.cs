using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correcao.Windows.Business.BusinessEntity;
using FluentNHibernate.Mapping;

namespace Correcao.Windows.Business.BusinessEntityMap
{
    public class ImagemMap : ClassMap<Imagem>
    {
        public ImagemMap()
        {
            Id(x => x.IdImagem, "ID_IMAGEM");            
            Map(x => x.Conteudo, "CONTENT_IMAGEM").Length(int.MaxValue);            
            Table("Imagem");
        }
    }
}
