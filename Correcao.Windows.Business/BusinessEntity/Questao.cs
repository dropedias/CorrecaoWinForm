using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao.Windows.Business.BusinessEntity
{
    public class Questao
    {
        public virtual int IdQuestao { get; set; }
        public virtual string Descricao { get; set; }
        public virtual TipoQuestao TipoQuestao { get; set; }               
    }
}
