using DAL;
using Models;
using System;
using System.Data;

namespace Regras
{
    public class RegraUsuario2 : RegrasAbstratas
    {
        usuarioDAL2 _usuarioDAL2 = new usuarioDAL2();


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
                    _usuarioDAL2.Excluir(parCodigo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraUsuario2: " + ex.Message);
            }
        }

        public override DataTable ListarDados()
        {
            try
            {
                return _usuarioDAL2.ListaUsuarios();
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("RegraUsuario2: " + ex.Message);
            }
        }

        public override void Salvar(Object parUsuario2)
        {
            try
            {
                if (((Usuario)parUsuario2).Nome.Trim().Length >= 51)
                {
                    throw new Exception("Nome do autor não pode ter mais que 50 caracteres.");
                }
                else
                {
                    if (((Usuario)parUsuario2).Email.Trim().Length >= 51)
                    {
                        throw new Exception("Email não pode ter mais que 50 caracteres.");
                    }
                    else if (((Usuario)parUsuario2).Senha.Trim().Length >= 6)
                    {
                        throw new Exception("Senha não pode ter mais que 6 caracteres.");
                    }
                    else
                    {
                        _usuarioDAL2.Salvar((Usuario)parUsuario2);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraUsuario2: " + ex.Message);
            }
        }
        public override void Atualizar(Object parUsuario2)
        {
            try
            {
                if (((Usuario)parUsuario2).Nome.Trim().Length >= 51)
                {
                    throw new Exception("Nome do usuário não pode ter mais que 50 caracteres.");
                }
                else
                {
                    _usuarioDAL2.Atualizar((Usuario)parUsuario2);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("RegraUsuario: " + ex.Message);
            }
        }
        public int ObterProximoID()
        {
            return _usuarioDAL2.ObterProximoId();
        }
    }
}
