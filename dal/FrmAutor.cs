﻿using DAL;
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
    public partial class FrmAutor : Form
    {
        FrmAutorPesquisa frmAutorPesquisa = new FrmAutorPesquisa();
        Autore autor = new Autore();
        autorDAL autordal = new autorDAL();

        private void LimparTela()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtPseudomino.Text = string.Empty;
            txtObservacao.Text = string.Empty;
        }
        public FrmAutor()
        {
            InitializeComponent();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            LimparTela();
            txtNome.Focus();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == string.Empty)
            {
                messages.Show("Nome é um campo obrigatório.", msgType.alert);
                txtNome.Focus();
                LimparTela();
            }
            else
            {
                if (txtCodigo.Text == string.Empty)
                {
                    txtCodigo.Text = autordal.ObterProximoId().ToString();
                    autor.Id = Int32.Parse(txtCodigo.Text);
                    autor.Nome = txtNome.Text;
                    autor.Observacao = txtObservacao.Text;
                    autor.Pseudomino = txtPseudomino.Text;

                    autordal.Salvar(autor);
                    messages.Show("Cadastro realizado com sucesso!", msgType.alert);
                    LimparTela();
                }
                else
                {
                    autor.Id = Int32.Parse(txtCodigo.Text);
                    autor.Nome = txtNome.Text;
                    autor.Observacao = txtObservacao.Text;
                    autor.Pseudomino = txtPseudomino.Text;


                    autordal.Atualizar(autor);
                    messages.Show("Cadastro atualizado com sucesso!", msgType.alert);
                    LimparTela();
                }


            }
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == string.Empty) || (txtCodigo.Text.Trim() == string.Empty))
            {
                messages.Show("Necessário informar o código do autor para exclusão.", msgType.alert);
            }
            else
            {
                autordal.Excluir(int.Parse(txtCodigo.Text));
                messages.Show("Autor excluído com sucesso!", msgType.alert);
                LimparTela();
            }
            txtNome.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmAutorPesquisa.ShowDialog();

            if (frmAutorPesquisa.autor.Id > 0)
            {
                txtCodigo.Text = frmAutorPesquisa.autor.Id.ToString();
                txtNome.Text = frmAutorPesquisa.autor.Nome;
                txtPseudomino.Text = frmAutorPesquisa.autor.Pseudomino;
                txtObservacao.Text = frmAutorPesquisa.autor.Observacao;
            }
        }
    }
}