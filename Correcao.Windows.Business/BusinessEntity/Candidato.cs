using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao.Windows.Business.BusinessEntity
{
    public class Candidato
    {
        public virtual int IdCandidato { get; set; }

        public virtual string Nome { get; set; }

        public virtual decimal ValorNota { get; set; }

        public virtual Imagem Imagem { get; set; }

        public virtual IList<Questao> Questoes { get; set; }

        public Candidato()
        {
            Questoes = new List<Questao>();
        }
    }
}
