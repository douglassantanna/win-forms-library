using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace DAL
{
    public class Conexao
    {
        private static SqlConnection _Conexao;
        private static SqlCommand _Comando;
        private static SqlDataAdapter _Adaptador;
        private static DataTable _Tabela;
        private static string _StringConexao = "Data Source=DESKTOP-HFDVDO8\\SQLEXPRESS; " +
        "Initial Catalog=SYSEDITORA; " +
        "Integrated Security=True;";

        public static SqlConnection ObterConexao()
        {
            try
            {
                _Conexao = new SqlConnection(_StringConexao);
                _Conexao.Open();
                return _Conexao;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public static void FecharConexao()
        {
            if (_Conexao.State == ConnectionState.Open)
            {
                _Conexao.Close();
            }
        }

    }
}
