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
    public partial class FrmLivrosPesquisa : Form
    {
        public Livro livro = new Livro();
        private livroDAL _livroDAL;

        private void _carregarGridLivros()
        {
            _livroDAL = new livroDAL();

            dgLivros.AutoGenerateColumns = true;
            dgLivros.DataSource = _livroDAL.ListasLivros();
        }
        private void _selecionarGridLivros()
        {
            Int32 vi = 0;
            vi = dgLivros.CurrentRow.Index;

            livro.Id = Int32.Parse(dgLivros[0, vi].Value.ToString());
            livro.Nome = dgLivros[1, vi].Value.ToString();
            livro.SBN = Int32.Parse(dgLivros[2, vi].Value.ToString());
            livro.AnoPublicacao = Int32.Parse(dgLivros[3, vi].Value.ToString());
            livro.Observacao = dgLivros[4, vi].Value.ToString();

        }

        private void _formatarGridLivros()
        {
            //nomeando colunas do dataGridView
            dgLivros.Columns[0].HeaderText = "ID";
            dgLivros.Columns[1].HeaderText = "Nome do livro";
            dgLivros.Columns[2].HeaderText = "SBN";
            dgLivros.Columns[3].HeaderText = "Ano de publicação";
            dgLivros.Columns[4].HeaderText = "Observações";

            //definindo largura das colunas do dataGridView
            dgLivros.Columns[0].Width = 40;
            dgLivros.Columns[1].Width = 180;
            dgLivros.Columns[2].Width = 40;
            dgLivros.Columns[3].Width = 60;
            dgLivros.Columns[4].Width = 150;

        }
        public FrmLivrosPesquisa()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            _carregarGridLivros();
        }

        private void FrmLivrosPesquisa_Load(object sender, EventArgs e)
        {
            livro.Id = 1;
            _carregarGridLivros();
            _formatarGridLivros();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            _selecionarGridLivros();
            this.Close();
        }
    }
}
