using Models;
using Regras;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmUsuarioPesquisa : Form
    {
        RegraUsuario2 _regraUsuario2 = new RegraUsuario2();
        public Usuario _usuario = new Usuario();
        public FrmUsuarioPesquisa()
        {
            InitializeComponent();
        }
        private void _carregarGridUsuarios()
        {
            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.DataSource = _regraUsuario2.ListarDados();
        }
        private void _selecionarGridUsuarios()
        {
            Int32 vi = 0;
            vi = dgUsuarios.CurrentRow.Index;

            _usuario.Codigo = Int32.Parse(dgUsuarios[0, vi].Value.ToString());
            _usuario.Nome = dgUsuarios[1, vi].Value.ToString();
            _usuario.Email = dgUsuarios[2, vi].Value.ToString();
            _usuario.Senha = dgUsuarios[3, vi].Value.ToString();
           
        }
        private void _formatarGridUsuarios()
        {
            //nomeando colunas do dataGridView
            dgUsuarios.Columns[0].HeaderText = "ID";
            dgUsuarios.Columns[1].HeaderText = "Nome do usuário";
            dgUsuarios.Columns[2].HeaderText = "Email";
            dgUsuarios.Columns[3].HeaderText = "Senha";

            //definindo largura das colunas do dataGridView
            dgUsuarios.Columns[0].Width = 40;
            dgUsuarios.Columns[1].Width = 140;
            dgUsuarios.Columns[2].Width = 140;
            dgUsuarios.Columns[3].Width = 60;


        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            _carregarGridUsuarios();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            _selecionarGridUsuarios();
            this.Close();
        }

        private void FrmUsuarioPesquisa_Load(object sender, EventArgs e)
        {
            _usuario.Codigo = 1;
            _carregarGridUsuarios();
            _formatarGridUsuarios();
        }
    }
}
