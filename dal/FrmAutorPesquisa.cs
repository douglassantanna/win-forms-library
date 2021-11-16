using DAL;
using Models;
using Regras;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmAutorPesquisa : Form
    {
        public Autore autor = new Autore();
        RegraAutor _regraAutor = new RegraAutor();

        private void _carregarGridAutores()
        {
            dgAutores.AutoGenerateColumns = true;
            dgAutores.DataSource = _regraAutor.ListarDados();
        }

        private void _selecionarGridAutores()
        {
            Int32 vi = 0;
            vi = dgAutores.CurrentRow.Index;

            autor.Id = Int32.Parse(dgAutores[0, vi].Value.ToString());
            autor.Nome = dgAutores[1, vi].Value.ToString();
            autor.Pseudomino = dgAutores[2, vi].Value.ToString();
            autor.Observacao = dgAutores[3, vi].Value.ToString();
        }

        private void _formatarGridAutores()
        {
            //nomeando colunas do dataGridView
            dgAutores.Columns[0].HeaderText = "ID";
            dgAutores.Columns[1].HeaderText = "Nome do autor";
            dgAutores.Columns[2].HeaderText = "Pseudomino";
            dgAutores.Columns[3].HeaderText = "Observações";

            //definindo largura das colunas do dataGridView
            dgAutores.Columns[0].Width = 40;
            dgAutores.Columns[1].Width = 180;
            dgAutores.Columns[2].Width = 80;
            dgAutores.Columns[3].Width = 190;

        }

        public FrmAutorPesquisa()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            _carregarGridAutores();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            _selecionarGridAutores();
            this.Close();
        }

        private void FrmAutorPesquisa_Load(object sender, EventArgs e)
        {
            autor.Id = 1;
            _carregarGridAutores();
            _formatarGridAutores();
        }
    }
}
