using DAL;
using System;

namespace Regras
{
    public class RegrasUsuario
    {
        usuarioDAL usuarioDAL = new usuarioDAL();
        public bool Login(string parEmail, string parSenha)
        {
            try
            {
                if((parEmail.Trim().Length <= 0) || (parSenha.Trim().Length <= 0))
                {
                    throw new Exception("RegrasUsuarios: O e-mail ou senha não são informados!");
                }
                else
                {
                    return usuarioDAL.Login(parEmail, parSenha);
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("RegrasUsuario: " + ex.Message);
            }
        }
    }
}
