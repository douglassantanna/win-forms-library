using DAL;
using Models;
using Regras;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmLivro : Form
    {
        RegraLivro _regraLivro = new RegraLivro();
        FrmLivrosPesquisa frmLivrosPesquisa = new FrmLivrosPesquisa();
        private editoraDAL _editoraDAL;
        Livro livro = new Livro();
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
            try
            {
                if ((txtNome.Text.Trim() == string.Empty) || (txtAnoPubli.Text.Trim() == string.Empty))
                {
                    messages.Show("Nome e ano de publicação são campos obrigatórios.", msgType.alert);
                    txtNome.Focus();
                }
                else
                {
                    if (txtCodigo.Text == string.Empty)
                    {
                        txtCodigo.Text = _regraLivro.ObterProximoID().ToString();
                        livro.Id = Int32.Parse(txtCodigo.Text);
                        livro.Nome = txtNome.Text;
                        livro.SBN = Int32.Parse(txtSBN.Text);
                        livro.AnoPublicacao = Int32.Parse(txtAnoPubli.Text);
                        livro.Observacao = txtObservacao.Text;
                        livro.Editora = Int32.Parse(cbSiglaEditora.SelectedValue.ToString());

                        _regraLivro.Salvar(livro);
                        messages.Show("Cadastro realizado com sucesso!", msgType.alert);
                        LimparTela();
                    }
                    else
                    {
                        livro.Id = Int32.Parse(txtCodigo.Text);
                        livro.Nome = txtNome.Text;
                        livro.SBN = Int32.Parse(txtSBN.Text);
                        livro.AnoPublicacao = Int32.Parse(txtAnoPubli.Text);
                        livro.Observacao = txtObservacao.Text;
                        livro.Editora = Int32.Parse(cbSiglaEditora.SelectedValue.ToString());

                        _regraLivro.Atualizar(livro);
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == string.Empty) || (txtCodigo.Text.Trim() == string.Empty))
            {
                messages.Show("Necessário informar o código da editora para exclusão.", msgType.alert);
            }
            else
            {
                _regraLivro.Excluir(int.Parse(txtCodigo.Text));
                messages.Show("Editora excluída com sucesso!", msgType.alert);
                LimparTela();
            }
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmLivrosPesquisa.ShowDialog();
            if(frmLivrosPesquisa.livro.Id > 0)
            {
                txtCodigo.Text = frmLivrosPesquisa.livro.Id.ToString();
                txtNome.Text = frmLivrosPesquisa.livro.Nome;
                txtSBN.Text = frmLivrosPesquisa.livro.SBN.ToString();
                txtAnoPubli.Text = frmLivrosPesquisa.livro.AnoPublicacao.ToString();
                txtObservacao.Text = frmLivrosPesquisa.livro.Observacao;
                cbSiglaEditora.SelectedValue = frmLivrosPesquisa.livro.Editora;
            }
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            _editoraDAL = new editoraDAL();
            CarregarComboEditoras();
        }
        private void CarregarComboEditoras()
        {
            //apontando de qual metodo o comboBox vai pegar as info
            cbSiglaEditora.DataSource = _editoraDAL.ListarEditoras();
            //apontando qual campo o comboBox vai exibir
            //apontando qual campo o comboBox vai exibir
            cbSiglaEditora.DisplayMember = "ediNome";
            //ediId representa o ID da editora
            cbSiglaEditora.ValueMember = "ediId";
        }
    }
}
