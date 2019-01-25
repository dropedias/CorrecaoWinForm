using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correcao.Windows.Business.BusinessEntity;
using FluentNHibernate.Mapping;

namespace Correcao.Windows.Business.BusinessEntityMap
{
    public class CandidatoMap : ClassMap<Candidato>
    {
        public CandidatoMap()
        {
            Table("Candidato");
            Id(x => x.IdCandidato);            
            Map(x => x.Nome, "NOME_CANDIDATO");
            Map(x => x.ValorNota, "VL_NOTA");
            References(x => x.Imagem).Column("ID_IMAGEM").Fetch.Join().Not.LazyLoad().Cascade.All();
            HasManyToMany(x => x.Questoes)
                .Cascade.SaveUpdate()                
                .Table("CANDIDATO_QUESTAO")
                .ParentKeyColumn("ID_CANDIDATO")
                .ChildKeyColumn("ID_QUESTAO");
        }
    }
}
