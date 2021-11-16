using DAL;
using Models;
using Regras;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmEditora : Form
    {
        RegraEditora _regraEditora = new RegraEditora();
        Editora editora = new Editora();
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
            try
            {
                if ((txtNome.Text.Trim() == string.Empty) || (txtSigla.Text.Trim() == string.Empty))
                {
                    messages.Show("Obrigatório preencher campo Nome e Sigla.", msgType.alert);
                    txtNome.Focus();
                }
                else
                {
                    if (txtCodigo.Text == string.Empty)
                    {
                        txtCodigo.Text = _regraEditora.ObterProximoID().ToString();
                        editora.Id = Int32.Parse(txtCodigo.Text);
                        editora.Nome = txtNome.Text;
                        editora.Sigla = txtSigla.Text;
                        editora.Observacao = txtObservacao.Text;

                        _regraEditora.Salvar(editora);
                        messages.Show("Cadastro realizado com sucesso!", msgType.alert);
                        LimparTela();
                    }
                    else
                    {
                        editora.Id = Int32.Parse(txtCodigo.Text);
                        editora.Nome = txtNome.Text;
                        editora.Sigla = txtSigla.Text;
                        editora.Observacao = txtObservacao.Text;

                        _regraEditora.Atualizar(editora);
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
                _regraEditora.Excluir(int.Parse(txtCodigo.Text));
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
