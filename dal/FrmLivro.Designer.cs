
namespace View
{
    partial class FrmLivro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSiglaEdit = new System.Windows.Forms.Label();
            this.cbSiglaEditora = new System.Windows.Forms.ComboBox();
            this.txtAnoPubli = new System.Windows.Forms.MaskedTextBox();
            this.txtSBN = new System.Windows.Forms.MaskedTextBox();
            this.lblAnoPubli = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSBN = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSiglaEdit);
            this.groupBox1.Controls.Add(this.cbSiglaEditora);
            this.groupBox1.Controls.Add(this.txtAnoPubli);
            this.groupBox1.Controls.Add(this.txtSBN);
            this.groupBox1.Controls.Add(this.lblAnoPubli);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblSBN);
            this.groupBox1.Controls.Add(this.lblObservacao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 281);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livros";
            // 
            // lblSiglaEdit
            // 
            this.lblSiglaEdit.AutoSize = true;
            this.lblSiglaEdit.Location = new System.Drawing.Point(355, 86);
            this.lblSiglaEdit.Name = "lblSiglaEdit";
            this.lblSiglaEdit.Size = new System.Drawing.Size(96, 15);
            this.lblSiglaEdit.TabIndex = 9;
            this.lblSiglaEdit.Text = "Nome da editora";
            // 
            // cbSiglaEditora
            // 
            this.cbSiglaEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiglaEditora.FormattingEnabled = true;
            this.cbSiglaEditora.Location = new System.Drawing.Point(355, 104);
            this.cbSiglaEditora.Name = "cbSiglaEditora";
            this.cbSiglaEditora.Size = new System.Drawing.Size(173, 23);
            this.cbSiglaEditora.TabIndex = 10;
            // 
            // txtAnoPubli
            // 
            this.txtAnoPubli.Location = new System.Drawing.Point(144, 104);
            this.txtAnoPubli.Mask = "00000";
            this.txtAnoPubli.Name = "txtAnoPubli";
            this.txtAnoPubli.Size = new System.Drawing.Size(159, 23);
            this.txtAnoPubli.TabIndex = 8;
            this.txtAnoPubli.ValidatingType = typeof(int);
            // 
            // txtSBN
            // 
            this.txtSBN.Location = new System.Drawing.Point(6, 104);
            this.txtSBN.Mask = "00000";
            this.txtSBN.Name = "txtSBN";
            this.txtSBN.Size = new System.Drawing.Size(100, 23);
            this.txtSBN.TabIndex = 6;
            this.txtSBN.ValidatingType = typeof(int);
            // 
            // lblAnoPubli
            // 
            this.lblAnoPubli.AutoSize = true;
            this.lblAnoPubli.Location = new System.Drawing.Point(144, 86);
            this.lblAnoPubli.Name = "lblAnoPubli";
            this.lblAnoPubli.Size = new System.Drawing.Size(159, 15);
            this.lblAnoPubli.TabIndex = 7;
            this.lblAnoPubli.Text = "Ano de publicação (ex: 1994)";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(6, 167);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(522, 65);
            this.txtObservacao.TabIndex = 12;
            this.txtObservacao.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(138, 252);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(126, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(4, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 23);
            this.txtCodigo.TabIndex = 2;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(270, 252);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(126, 23);
            this.btnRemover.TabIndex = 15;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(136, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(402, 252);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(126, 23);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 252);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(126, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(392, 23);
            this.txtNome.TabIndex = 4;
            // 
            // lblSBN
            // 
            this.lblSBN.AutoSize = true;
            this.lblSBN.Location = new System.Drawing.Point(4, 86);
            this.lblSBN.Name = "lblSBN";
            this.lblSBN.Size = new System.Drawing.Size(87, 15);
            this.lblSBN.TabIndex = 5;
            this.lblSBN.Text = "SBN (números)";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(6, 149);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(74, 15);
            this.lblObservacao.TabIndex = 11;
            this.lblObservacao.Text = "Observações";
            // 
            // FrmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 306);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLivro";
            this.Text = "Livro";
            this.Load += new System.EventHandler(this.FrmLivro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtObservacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSBN;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblAnoPubli;
        private System.Windows.Forms.MaskedTextBox txtSBN;
        private System.Windows.Forms.MaskedTextBox txtAnoPubli;
        private System.Windows.Forms.ComboBox cbSiglaEditora;
        private System.Windows.Forms.Label lblSiglaEdit;
    }
}