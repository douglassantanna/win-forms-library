using Models;
using Regras;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmAutor : Form
    {
        RegraAutor regraAutor = new RegraAutor();
        FrmAutorPesquisa frmAutorPesquisa = new FrmAutorPesquisa();
        Autore autor = new Autore();

        private void LimparTela()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtPseudomino.Text = string.Empty;
            txtObservacao.Text = string.Empty;
        }
        public FrmAutor()
        {
            InitializeComponent();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            LimparTela();
            txtNome.Focus();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text.Trim() == string.Empty)
                {
                    messages.Show("Nome é um campo obrigatório.", msgType.alert);
                    txtNome.Focus();
                    LimparTela();
                }
                else
                {
                    if (txtCodigo.Text == string.Empty)
                    {
                        txtCodigo.Text = regraAutor.ObterProximoID().ToString();
                        autor.Id = Int32.Parse(txtCodigo.Text);
                        autor.Nome = txtNome.Text;
                        autor.Observacao = txtObservacao.Text;
                        autor.Pseudomino = txtPseudomino.Text;

                        regraAutor.Salvar(autor);
                        messages.Show("Cadastro realizado com sucesso!", msgType.alert);
                        LimparTela();
                    }
                    else
                    {
                        autor.Id = Int32.Parse(txtCodigo.Text);
                        autor.Nome = txtNome.Text;
                        autor.Observacao = txtObservacao.Text;
                        autor.Pseudomino = txtPseudomino.Text;


                        regraAutor.Atualizar(autor);
                        messages.Show("Cadastro atualizado com sucesso!", msgType.alert);
                        LimparTela();
                    }
                }
            }
            catch(Exception ex)
            {
                messages.Show(ex.Message.ToString(), msgType.error);
            }
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((txtCodigo.Text == string.Empty) || (txtCodigo.Text.Trim() == string.Empty))
                {
                    messages.Show("Necessário informar o código do autor para exclusão.", msgType.alert);
                }
                else
                {
                    regraAutor.Excluir(int.Parse(txtCodigo.Text));
                    messages.Show("Autor excluído com sucesso!", msgType.alert);
                    LimparTela();
                }
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                messages.Show(ex.Message, msgType.error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmAutorPesquisa.ShowDialog();

            if (frmAutorPesquisa.autor.Id > 0)
            {
                txtCodigo.Text = frmAutorPesquisa.autor.Id.ToString();
                txtNome.Text = frmAutorPesquisa.autor.Nome;
                txtPseudomino.Text = frmAutorPesquisa.autor.Pseudomino;
                txtObservacao.Text = frmAutorPesquisa.autor.Observacao;
            }
        }
    }
}