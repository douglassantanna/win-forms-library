using System;
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            if (frmLogin.acessoPermitido == false)
            {
                this.Close();
               
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario us = new FrmUsuario();
            us.ShowDialog();

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre sb = new FrmSobre();
            sb.ShowDialog();
        }
    }
}
