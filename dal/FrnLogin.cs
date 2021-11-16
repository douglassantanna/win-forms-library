using Regras;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmLogin : Form
    {
        public bool acessoPermitido = false;
        private RegrasUsuario _regrasUsuarios = new RegrasUsuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmail.Text.Trim() == string.Empty)
                {
                    messages.Show("Necessário informar o e-amil", msgType.alert);
                    txtEmail.Focus();
                }
                else if(txtPassword.Text.Trim() == string.Empty)
                {
                    messages.Show("Necessário informar a senha", msgType.alert);
                    txtPassword.Focus();
                }
                else if (txtEmail.Text.Contains("@") == false)
                {
                    messages.Show("Email informado não é valido!", msgType.alert);
                    txtEmail.Focus();
                }
                else if(_regrasUsuarios.Login(txtEmail.Text, txtPassword.Text) == true)
                {
                    messages.Show("E-mail e/ou senha informado não é válido! Tente novamente.", msgType.alert);
                    txtEmail.Focus();
                }
                else
                {
                    this.acessoPermitido = true;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
