using DAL;
using Models;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmEditora : Form
    {
        Editora editora = new Editora();
        editoraDAL editoradal = new editoraDAL();
        FrmEditoraPesquisa frmEditoraPesquisa = new FrmEditoraPesquisa();
        private void LimparTela()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSigla.Text = string.Empty;
            txtObservacao.Text = string.Empty;
        }
        public FrmEditora()
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
            if ((txtNome.Text.Trim() == string.Empty) || (txtSigla.Text.Trim() == string.Empty))
            {
                messages.Show("Obrigatório preencher campo Nome e Sigla.", msgType.alert);
                txtNome.Focus();
            }
            else
            {
                if(txtCodigo.Text == string.Empty)
                {
                    txtCodigo.Text = editoradal.ObterProximoId().ToString();
                    editora.Id = Int32.Parse(txtCodigo.Text);
                    editora.Nome = txtNome.Text;
                    editora.Sigla = txtSigla.Text;
                    editora.Observacao = txtObservacao.Text;

                    editoradal.Salvar(editora);
                    messages.Show("Cadastro realizado com sucesso!", msgType.alert);
                    LimparTela();
                }
                else
                {
                    editora.Id = Int32.Parse(txtCodigo.Text);
                    editora.Nome = txtNome.Text;
                    editora.Sigla = txtSigla.Text;
                    editora.Observacao = txtObservacao.Text;

                    editoradal.Atualizar(editora);
                    messages.Show("Cadastro atualizado com sucesso!", msgType.alert);
                    LimparTela();
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
                editoradal.Excluir(int.Parse(txtCodigo.Text));
                messages.Show("Editora excluída com sucesso!", msgType.alert);
                LimparTela();
            }
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmEditoraPesquisa.ShowDialog();

            if (frmEditoraPesquisa.editora.Id > 0)
            {
                txtCodigo.Text = frmEditoraPesquisa.editora.Id.ToString();
                txtNome.Text = frmEditoraPesquisa.editora.Nome;
                txtSigla.Text = frmEditoraPesquisa.editora.Sigla;
                txtObservacao.Text = frmEditoraPesquisa.editora.Observacao;
            }
        }
    }
}
