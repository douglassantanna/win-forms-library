using Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class usuarioDAL
    {
        private SqlConnection _connSQL;
        private SqlCommand _comandoSQL;
        private static SqlDataAdapter _Adaptador;
        private static DataTable _Tabela;

        public bool Login(string parEmail, string parSenha)
        {
            try
            {
                int Id = 0;
                _connSQL = Conexao.ObterConexao();
                _comandoSQL = new SqlCommand();
                _comandoSQL.Connection = _connSQL;
                _comandoSQL.CommandText = "select isnull(max(usuId ), 0) + 1 as usuId   " +
                                           "from tblUsuarios  " +
                                           " where usuEmail = @usuEmail" +
                                           " and usuSenha = @usuSenha";

                _comandoSQL.Parameters.Add("@usuemail", SqlDbType.VarChar).Value = parEmail;
                _comandoSQL.Parameters.Add("@ususenha", SqlDbType.VarChar).Value = parSenha;

                Id = int.Parse(_comandoSQL.ExecuteScalar().ToString());

                Conexao.FecharConexao();

                if (Id == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("usuarioDAL: " + ex.Message);
            }
        }
    }
}
