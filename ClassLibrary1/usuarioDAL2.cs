using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class usuarioDAL2
    {
        private SqlConnection _connSQL;
        private SqlCommand _comandoSQL;
        private static SqlDataAdapter _Adaptador;
        private static DataTable _Tabela;

        public int ObterProximoId()
        {
            int Id = 0;
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "select isnull(max(usuId), 0) + 1 as usuId  " +
                                       "from tblUsuarios";
            Id = int.Parse(_comandoSQL.ExecuteScalar().ToString());
            Conexao.FecharConexao();

            return Id;
        }
        public void Salvar(Usuario usuario)
        {
            //insert
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "insert into tblUsuarios (usuId, usuNome, usuEmail, usuSenha)" +
                                                    "values (@usuId, @usuNome, @usuEmail, @usuSenha)";

            _comandoSQL.Parameters.Add("@usuId", SqlDbType.Int).Value = usuario.Codigo;
            _comandoSQL.Parameters.Add("@usuNome", SqlDbType.VarChar).Value = usuario.Nome;
            _comandoSQL.Parameters.Add("@usuEmail", SqlDbType.VarChar).Value = usuario.Email;
            _comandoSQL.Parameters.Add("@usuSenha", SqlDbType.VarChar).Value = usuario.Senha;
           

            _comandoSQL.ExecuteNonQuery();

            Conexao.FecharConexao();
        }
        public void Atualizar(Usuario usuario)
        {
            //update
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "update tblUsuarios " +
                                       "set usuId = @usuId, " +
                                       "usuNome = @usuNome, " +
                                       "usuEmail = @usuEmail, " +
                                       "usuSenha = @usuSenha " +
                                       "where usuId = @usuId";

            _comandoSQL.Parameters.Add("@usuId", SqlDbType.Int).Value = usuario.Codigo;
            _comandoSQL.Parameters.Add("@usuNome", SqlDbType.VarChar).Value = usuario.Nome;
            _comandoSQL.Parameters.Add("@usuEmail", SqlDbType.VarChar).Value = usuario.Email;
            _comandoSQL.Parameters.Add("@usuSenha", SqlDbType.VarChar).Value = usuario.Senha;

            _comandoSQL.ExecuteNonQuery();

            Conexao.FecharConexao();

        }
        public void Excluir(int usuario)
        {
            //delete
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "delete from tblUsuarios where usuId = @usuId";

            _comandoSQL.Parameters.Add("@usuId", SqlDbType.Int).Value = usuario;
            _comandoSQL.ExecuteNonQuery();
            Conexao.FecharConexao();

        }
        public DataTable ListaUsuarios()
        {
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "select usuId, usuNome, usuEmail, usuSenha" +
            " from tblUsuarios " +
            " order by usuId asc";



            _Tabela = new DataTable();
            _Adaptador = new SqlDataAdapter(_comandoSQL);
            _Adaptador.Fill(_Tabela);

            Conexao.FecharConexao();

            return _Tabela;
        }

    }
}
