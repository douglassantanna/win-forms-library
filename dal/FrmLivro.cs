using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmLivro : Form
    {
        private void LimparTela()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtAnoPubli.Text = string.Empty;
            txtSBN.Text = string.Empty;
            txtObservacao.Text = string.Empty;
        }
        public FrmLivro()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparTela();
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livroDAL livrodal = new livroDAL();


            if ((txtNome.Text.Trim() == string.Empty) || (txtAnoPubli.Text.Trim() == string.Empty))
            {
                messages.Show("Nome e ano de publicação são campos obrigatórios.", msgType.alert);
                txtNome.Focus();
            }
            else
            {
                if (txtCodigo.Text == string.Empty)
                {
                    txtCodigo.Text = livrodal.ObterProximoId().ToString();
                    livro.Id = Int32.Parse(txtCodigo.Text);
                    livro.Nome = txtNome.Text;
                    livro.SBN = Int32.Parse(txtSBN.Text);
                    livro.AnoPublicacao = Int32.Parse(txtAnoPubli.Text);
                    livro.Observacao = txtObservacao.Text;

                    livrodal.Salvar(livro);
                    messages.Show("Cadastro realizado com sucesso!", msgType.alert);
                }
                else
                {
                    livro.Id = Int32.Parse(txtCodigo.Text);
                    livro.Nome = txtNome.Text;
                    livro.SBN = Int32.Parse(txtSBN.Text);
                    livro.AnoPublicacao = Int32.Parse(txtAnoPubli.Text);
                    livro.Observacao = txtObservacao.Text;


                    livrodal.Atualizar(livro);
                    messages.Show("Cadastro atualizado com sucesso!", msgType.alert);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == string.Empty) || (txtCodigo.Text.Trim() == string.Empty))
            {
                messages.Show("Necessário informar o código da editora para exclusão.", msgType.alert);
            }
            else
            {
                livroDAL livrodal = new livroDAL();
                livrodal.Excluir(int.Parse(txtCodigo.Text));
                messages.Show("Editora excluída com sucesso!", msgType.alert);
            }
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmLivrosPesquisa frmLivrosPesquisa = new FrmLivrosPesquisa();
            frmLivrosPesquisa.ShowDialog();

            if(frmLivrosPesquisa.livro.Id>= 0)
            {
                txtCodigo.Text = frmLivrosPesquisa.livro.Id.ToString();
                txtNome.Text = frmLivrosPesquisa.livro.Nome.ToString();
                txtSBN.Text = frmLivrosPesquisa.livro.SBN.ToString();
                txtAnoPubli.Text = frmLivrosPesquisa.livro.AnoPublicacao.ToString();
                txtObservacao.Text = frmLivrosPesquisa.livro.Observacao.ToString();
            }
        }
    }
}
