namespace Correcao.Windows
{
    partial class CarregarImagemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnCandidato = new System.Windows.Forms.Button();
            this.dgQuestoes = new System.Windows.Forms.DataGridView();
            this.lblGridQuestoes = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblImagem = new System.Windows.Forms.Label();
            this.txtIdImagem = new System.Windows.Forms.TextBox();
            this.lblIdImagem = new System.Windows.Forms.Label();
            this.btnExibirImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuestoes)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.picImage.Location = new System.Drawing.Point(12, 73);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(483, 411);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // btnCandidato
            // 
            this.btnCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidato.Location = new System.Drawing.Point(696, 34);
            this.btnCandidato.Name = "btnCandidato";
            this.btnCandidato.Size = new System.Drawing.Size(255, 33);
            this.btnCandidato.TabIndex = 3;
            this.btnCandidato.Text = "Cadastrar Candidatos Questões";
            this.btnCandidato.UseVisualStyleBackColor = true;
            this.btnCandidato.Click += new System.EventHandler(this.btnCandidato_Click);
            // 
            // dgQuestoes
            // 
            this.dgQuestoes.AllowUserToAddRows = false;
            this.dgQuestoes.AllowUserToDeleteRows = false;
            this.dgQuestoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuestoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao});
            this.dgQuestoes.Location = new System.Drawing.Point(501, 73);
            this.dgQuestoes.Name = "dgQuestoes";
            this.dgQuestoes.ReadOnly = true;
            this.dgQuestoes.Size = new System.Drawing.Size(450, 411);
            this.dgQuestoes.TabIndex = 4;
            // 
            // lblGridQuestoes
            // 
            this.lblGridQuestoes.AutoSize = true;
            this.lblGridQuestoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridQuestoes.Location = new System.Drawing.Point(497, 47);
            this.lblGridQuestoes.Name = "lblGridQuestoes";
            this.lblGridQuestoes.Size = new System.Drawing.Size(173, 20);
            this.lblGridQuestoes.TabIndex = 5;
            this.lblGridQuestoes.Text = "Questões Cadastradas";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 400;
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem.Location = new System.Drawing.Point(12, 47);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(251, 20);
            this.lblImagem.TabIndex = 6;
            this.lblImagem.Text = "Exibição da Imagem do Candidato";
            // 
            // txtIdImagem
            // 
            this.txtIdImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdImagem.Location = new System.Drawing.Point(173, 8);
            this.txtIdImagem.Name = "txtIdImagem";
            this.txtIdImagem.Size = new System.Drawing.Size(56, 26);
            this.txtIdImagem.TabIndex = 7;
            // 
            // lblIdImagem
            // 
            this.lblIdImagem.AutoSize = true;
            this.lblIdImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdImagem.Location = new System.Drawing.Point(8, 11);
            this.lblIdImagem.Name = "lblIdImagem";
            this.lblIdImagem.Size = new System.Drawing.Size(159, 20);
            this.lblIdImagem.TabIndex = 8;
            this.lblIdImagem.Text = "ID da Imagem no BD";
            // 
            // btnExibirImagem
            // 
            this.btnExibirImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirImagem.Location = new System.Drawing.Point(248, 5);
            this.btnExibirImagem.Name = "btnExibirImagem";
            this.btnExibirImagem.Size = new System.Drawing.Size(132, 33);
            this.btnExibirImagem.TabIndex = 9;
            this.btnExibirImagem.Text = "Exibir Imagem";
            this.btnExibirImagem.UseVisualStyleBackColor = true;
            this.btnExibirImagem.Click += new System.EventHandler(this.btnExibirImagem_Click);
            // 
            // CarregarImagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 496);
            this.Controls.Add(this.btnExibirImagem);
            this.Controls.Add(this.lblIdImagem);
            this.Controls.Add(this.txtIdImagem);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.lblGridQuestoes);
            this.Controls.Add(this.dgQuestoes);
            this.Controls.Add(this.btnCandidato);
            this.Controls.Add(this.picImage);
            this.Name = "CarregarImagemForm";
            this.Text = "Geração de Imagens - Módulo Desktop";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuestoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnCandidato;
        private System.Windows.Forms.DataGridView dgQuestoes;
        private System.Windows.Forms.Label lblGridQuestoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.TextBox txtIdImagem;
        private System.Windows.Forms.Label lblIdImagem;
        private System.Windows.Forms.Button btnExibirImagem;
    }
}

