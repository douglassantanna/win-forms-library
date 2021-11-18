using Models;
using Regras;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmUsuario : Form
    {
        RegraUsuario2 _regraUsuario2 = new RegraUsuario2();
        Usuario _usuario = new Usuario();
        FrmUsuarioPesquisa frmUsuarioPesquisa = new FrmUsuarioPesquisa();
        public FrmUsuario()
        {
            InitializeComponent();
        }
        private void LimparTela()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            LimparTela();
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (txtNome.Text.Trim() == string.Empty)
                {
                    messages.Show("Nome é um campo obrigatório.", msgType.alert);
                    txtNome.Focus();
                }
                else
                {
                    if (txtCodigo.Text == string.Empty)
                    {
                        txtCodigo.Text = _regraUsuario2.ObterProximoID().ToString();
                        _usuario.Codigo = int.Parse(txtCodigo.Text);
                        _usuario.Nome = txtNome.Text;
                        _usuario.Email = txtEmail.Text;
                        _usuario.Senha = txtSenha.Text;

                        _regraUsuario2.Salvar(_usuario);
                        messages.Show("Cadastro realizado com sucesso!", msgType.alert);
                        LimparTela();
                    }
                    else
                    {
                        _usuario.Codigo = int.Parse(txtCodigo.Text);
                        _usuario.Nome = txtNome.Text;
                        _usuario.Email = txtEmail.Text;
                        _usuario.Senha = txtSenha.Text;


                        _regraUsuario2.Atualizar(_usuario);
                        messages.Show("Cadastro atualizado com sucesso!", msgType.alert);
                        LimparTela();
                    }
                }
            }
            catch (Exception ex)
            {
                messages.Show(ex.Message.ToString(), msgType.error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtCodigo.Text == string.Empty) || (txtCodigo.Text.Trim() == string.Empty))
                {
                    messages.Show("Necessário informar o código do usuário para exclusão.", msgType.alert);
                }
                else
                {
                    _regraUsuario2.Excluir(int.Parse(txtCodigo.Text));
                    messages.Show("Usuário excluído com sucesso!", msgType.alert);
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
            frmUsuarioPesquisa.ShowDialog();

            if (frmUsuarioPesquisa._usuario.Codigo > 0)
            {
                txtCodigo.Text = frmUsuarioPesquisa._usuario.Codigo.ToString();
                txtNome.Text = frmUsuarioPesquisa._usuario.Nome;
                txtEmail.Text = frmUsuarioPesquisa._usuario.Email;
                txtSenha.Text = frmUsuarioPesquisa._usuario.Senha;
            }
        }
    }
    
}
