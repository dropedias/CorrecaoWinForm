using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Correcao.Windows.Business;
using Correcao.Windows.Business.BusinessEntity;
using System.Threading;

namespace Correcao.Windows
{
    public partial class CarregarImagemForm : Form
    {
        public CarregarImagemForm()
        {
            InitializeComponent();

            CarregarGridQuestoes();
        }

        #region Variáveis e Propriedades

        private ImagemBO imagemBO;
        private CandidatoBO candidatoBO;
        private QuestaoBO questaoBO;

        // Propriedades Singleton
        public ImagemBO ImagemBO
        {
            get
            {
                if (imagemBO == null)
                {
                    imagemBO = new ImagemBO();
                }

                return imagemBO;
            }
        }

        public CandidatoBO CandidatoBO
        {
            get
            {
                if (candidatoBO == null)
                {
                    candidatoBO = new CandidatoBO();
                }

                return candidatoBO;
            }
        }

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

        protected void CarregarGridQuestoes()
        {
            try
            {
                var questoes = QuestaoBO.GetQuestoes();

                dgQuestoes.DataSource = questoes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Método para testar uma imagem do banco.
        public void GetImagemCandidato(int idImagem)
        {
            Imagem imagem = ImagemBO.GetImagem(idImagem);

            if (imagem == null) throw new Exception();

            using (var ms = new MemoryStream(imagem.Conteudo))
            {
                picImage.Image = Image.FromStream(ms);
            }
        }

        private void GerarCandidatos()
        {
            Queue<Thread> threadBuffer = new Queue<Thread>();

            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(new ThreadStart(CandidatoBO.GerarCandidatos));
                thread.IsBackground = true;
                threadBuffer.Enqueue(thread);
            }

            while (threadBuffer.Count > 0)
            {
                Thread t = threadBuffer.Dequeue();
                t.Start();
                Thread.Sleep(3000);
            }            
        }

        #endregion

        #region Eventos

        private void btnCandidato_Click(object sender, EventArgs e)
        {
            try
            {
                GerarCandidatos();

                MessageBox.Show("Candidatos gerados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExibirImagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdImagem.Text == "")
                {
                    MessageBox.Show("O campo 'ID da Imagem no BD' deve ser preenchido.");
                    return;
                }

                GetImagemCandidato(Convert.ToInt32(txtIdImagem.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não existe esse ID de imagem no banco de dados.");
            }
            finally
            {
                txtIdImagem.Text = "";
            }
        }

        #endregion        
    }
}
