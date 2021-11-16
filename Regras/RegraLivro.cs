using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras
{
    public class RegraLivro : RegrasAbstratas
    {
        livroDAL _livroDAL = new livroDAL();

        public int ObterProximoID()
        {
            return _livroDAL.ObterProximoId();
        }
        public override void Salvar(object parLivro)
        {
            try
            {
                if (((Livro)parLivro).Nome.Trim().Length >= 51)
                {
                    throw new Exception("Nome do livro não pode ter mais que 50 caracteres.");
                }
                else
                {
                    _livroDAL.Salvar((Livro)parLivro);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraLivro: " + ex.Message);
            }
        }
        public override void Atualizar(object parLivro)
        {
            try
            {
                if (((Livro)parLivro).Nome.Trim().Length >= 51)
                {
                    throw new Exception("Nome do livro não pode ter mais que 50 caracteres.");
                }
                else
                {
                    if (((Livro)parLivro).Id < 1)
                    {
                        throw new Exception("O valor para o campo codigo deve ser maior que zero.");
                    }
                    else
                    {
                        _livroDAL.Atualizar((Livro)parLivro);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraLivro: " + ex.Message);
            }
        }

        public override void Excluir(int parCodigo)
        {
            try
            {
                if (parCodigo <= 0)
                {
                    throw new Exception("O codigo deve ser um valor maior que zero.");
                }
                else
                {
                    _livroDAL.Excluir(parCodigo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraLivro: " + ex.Message);
            }
        }

        public override DataTable ListarDados()
        {
            try
            {
                return _livroDAL.ListasLivros();
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("RegraLivro: " + ex.Message);
            }
        }

    }
}
