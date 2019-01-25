using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using Correcao.Windows.Business.BusinessEntity;
using NHibernate;
using System.Threading;

namespace Correcao.Windows.Business
{
    public class CandidatoBO
    {
        #region Variáveis e Propriedades
        
        private QuestaoBO questaoBO;

        public QuestaoBO QuestaoBO
        {
            get
            {
                if (questaoBO == null)
                {
                    questaoBO = new QuestaoBO();
                }

                return questaoBO;
            }
        }
        #endregion

        #region Métodos
        public void InserirCandidatos(IList<Candidato> candidatos)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        foreach (var candidato in candidatos)
                        {
                            session.Save(candidato);
                        }

                        transaction.Commit();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void GerarCandidatos()
        {
            Thread.Sleep(3000);

            const int QUANTIDADE_CANDIDATOS = 10;
            List<Candidato> candidatos;

            var questoes = QuestaoBO.GetQuestoes();

            foreach (var questao in questoes)
            {
                candidatos = new List<Candidato>();                            

                for (int i = 0; i < QUANTIDADE_CANDIDATOS; i++)
                {
                    var candidato = new Candidato();
                    candidato.Nome = string.Format("Fulano da Silva {0}-{1}", i, questao.IdQuestao);
                    candidato.Imagem = GerarImagemCandidato(candidato.Nome, questao.IdQuestao);
                    candidato.Questoes.Add(questao);

                    candidatos.Add(candidato);
                }

                InserirCandidatos(candidatos);
            }
        }    

        public Imagem GerarImagemCandidato(string nomeCandidato, int idQuestao)
        {
            Imagem imagem = new Imagem();

            string strFn = System.IO.Path.GetFullPath(@"..\..\ImagemExemplo\FolhaRedacao.jpg");

            if (string.IsNullOrEmpty(strFn)) return null;            

            var image = Image.FromFile(strFn);

            if (image != null)
            {
                using (Graphics grafico = Graphics.FromImage(image))
                {
                    Brush pincel = new SolidBrush(Color.Black);

                    Font fonte = new Font("Courier New", 16, FontStyle.Bold);

                    grafico.DrawString(string.Format("Questão: {0}", idQuestao), fonte, pincel, 25, 23);
                    grafico.DrawString(string.Format("Candidato: {0}", nomeCandidato), fonte, pincel, 25, 43);
                }

                image.Save(nomeCandidato);

                using (var ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    imagem.Conteudo = ms.ToArray();
                }
            }

            image.Dispose();

            return imagem;
        }

        #endregion
    }
}
