using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;

namespace dal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditora ed = new FrmEditora();
            ed.ShowDialog();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLivro lv = new FrmLivro();
            lv.ShowDialog();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutor au = new FrmAutor();
            au.ShowDialog();
        }
    }
}
