using DAL;
using Models;
using System;
using System.Data;

namespace Regras
{
    public class RegraAutor: RegrasAbstratas
    {
        autorDAL _autorDAL = new autorDAL();

        public override void Atualizar(Object parAutor)
        {
            try
            {
                if (((Autore)parAutor).Nome.Trim().Length >= 51)
                {
                    throw new Exception("Nome do autor não pode ter mais que 50 caracteres.");
                }
                else
                {
                    if (((Autore)parAutor).Pseudomino.Trim().Length >= 51)
                    {
                        throw new Exception("Pseudomino do autor não pode ter mais que 50 caracteres.");
                    }
                    else
                    {
                        _autorDAL.Atualizar((Autore)parAutor);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraAutor: " + ex.Message);
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
                    _autorDAL.Excluir(parCodigo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraAutor: " + ex.Message);
            }
        }

        public override DataTable ListarDados()
        {
            try
            {
                return _autorDAL.ListarAutores();
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("RegraAutor: " + ex.Message);
            }
        }

        public int ObterProximoID()
        {
            return _autorDAL.ObterProximoId();
        }
        public override void Salvar(Object parAutor)
        {
            try
            {
                if (((Autore)parAutor).Nome.Trim().Length >= 51)
                {
                    throw new Exception("Nome do autor não pode ter mais que 50 caracteres.");
                }
                else
                {
                    if (((Autore)parAutor).Pseudomino.Trim().Length >= 51)
                    {
                        throw new Exception("Pseudomino do autor não pode ter mais que 50 caracteres.");
                    }
                    else
                    {
                        _autorDAL.Salvar((Autore)parAutor);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraAutor: " + ex.Message);
            }
        }
    }
}
