using DAL;
using Models;
using Regras;
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
    public partial class FrmEditoraPesquisa : Form
    {
        public Editora editora = new Editora();
        RegraEditora _regraEditora = new RegraEditora();
        public FrmEditoraPesquisa()
        {
            InitializeComponent();
        }

        private void _carregarGridEditoras()
        {
            dgEditoras.AutoGenerateColumns = true;
            dgEditoras.DataSource = _regraEditora.ListarDados();
        }
        private void _selecionarGridEditoras()
        {
            Int32 vi = 0;
            vi = dgEditoras.CurrentRow.Index;

            editora.Id = Int32.Parse(dgEditoras[0, vi].Value.ToString());
            editora.Nome = dgEditoras[1, vi].Value.ToString();
            editora.Sigla = dgEditoras[2, vi].Value.ToString();
            editora.Observacao = dgEditoras[3, vi].Value.ToString();
        }
        private void _formatarGridEditoras()
        {
            //nomeando colunas do dataGridView
            dgEditoras.Columns[0].HeaderText = "ID";
            dgEditoras.Columns[1].HeaderText = "Nome da editora";
            dgEditoras.Columns[2].HeaderText = "Sigla";
            dgEditoras.Columns[3].HeaderText = "Observações";

            //definindo largura das colunas do dataGridView
            dgEditoras.Columns[0].Width = 40;
            dgEditoras.Columns[1].Width = 180;
            dgEditoras.Columns[2].Width = 40;
            dgEditoras.Columns[3].Width = 250;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            _carregarGridEditoras();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            _selecionarGridEditoras();
            this.Close();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditoraPesquisa_Load(object sender, EventArgs e)
        {
            editora.Id = 1;
            _carregarGridEditoras();
            _formatarGridEditoras();
        }
    }
}
