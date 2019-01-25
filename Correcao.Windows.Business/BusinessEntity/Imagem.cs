using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao.Windows.Business.BusinessEntity
{
    public class Imagem
    {
        public virtual int IdImagem { get; set; }
        public virtual byte[] Conteudo { get; set; }
    }
}
