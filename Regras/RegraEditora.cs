using DAL;
using Models;
using System;
using System.Data;

namespace Regras
{
    public class RegraEditora : RegrasAbstratas
    {
        editoraDAL _editoraDAL = new editoraDAL();
        public int ObterProximoID()
        {
            return _editoraDAL.ObterProximoId();
        }
        public override void Salvar(Object parEditora)
        {
            try
            {
                if (((Editora)parEditora).Nome.Trim().Length >= 51)
                {
                    throw new Exception("Nome da editora não pode ter mais que 50 caracteres.");
                }
                else
                {
                    if (((Editora)parEditora).Sigla.Trim().Length >= 26)
                    {
                        throw new Exception("Sigla da editora não pode ter mais que 25 caracteres.");
                    }
                    else
                    {
                        _editoraDAL.Salvar((Editora)parEditora);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraEditora: " + ex.Message);
            }
        }
        public override void Atualizar(Object parEditora)
        {
            try
            {
                if (((Editora)parEditora).Nome.Trim().Length >= 51)
                {
                    throw new Exception("Nome da editora não pode ter mais que 50 caracteres.");
                }
                else
                {
                    if (((Editora)parEditora).Sigla.Trim().Length >= 26)
                    {
                        throw new Exception("Sigla da editora não pode ter mais que 25 caracteres.");
                    }
                    else
                    {
                        _editoraDAL.Atualizar((Editora)parEditora);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraEditora: " + ex.Message);
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
                    _editoraDAL.Excluir(parCodigo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraEditora: " + ex.Message);
            }
        }
        public override DataTable ListarDados()
        {
            try
            {
                return _editoraDAL.ListarEditoras();
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("RegraEditora: " + ex.Message);
            }
        }
    }
}
