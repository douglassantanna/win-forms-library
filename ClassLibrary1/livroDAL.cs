using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class livroDAL
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
                _comandoSQL.CommandText = "select isnull(max(livId), 0) + 1 as livId  " +
                                           "from TblLivro";
                Id = int.Parse(_comandoSQL.ExecuteScalar().ToString());
                Conexao.FecharConexao();

                return Id;
            }
        public void Salvar(Livro livro)
            {
                //insert
                _connSQL = Conexao.ObterConexao();
                _comandoSQL = new SqlCommand();
                _comandoSQL.Connection = _connSQL;
                _comandoSQL.CommandText = "insert into TblLivro (livId, livNome, livAnoPubli, livSbn, livObserv, ediId)" +
                                                        "values (@livId, @livNome, @livAnoPubli, @livSbn, @livObserv, @ediId)";

                _comandoSQL.Parameters.Add("@livId", SqlDbType.Int).Value = livro.Id;
                _comandoSQL.Parameters.Add("@livNome", SqlDbType.VarChar).Value = livro.Nome;
                _comandoSQL.Parameters.Add("@livAnoPubli", SqlDbType.Int).Value = livro.AnoPublicacao;
                _comandoSQL.Parameters.Add("@livSbn", SqlDbType.Int).Value = livro.SBN;
                _comandoSQL.Parameters.Add("@livObserv", SqlDbType.VarChar).Value = livro.Observacao;
                 _comandoSQL.Parameters.Add("@ediId", SqlDbType.Int).Value = livro.Editora;

                _comandoSQL.ExecuteNonQuery();

                Conexao.FecharConexao();
            }
        public void Atualizar(Livro livro)
            {
                //update
                _connSQL = Conexao.ObterConexao();
                _comandoSQL = new SqlCommand();
                _comandoSQL.Connection = _connSQL;
                _comandoSQL.CommandText = "update TblLivro " +
                                           "set livNome = @livNome, " +
                                           "livAnoPubli = @livAnoPubli, " +
                                           "livObserv = @livObserv, " +
                                           "livSbn = @livSbn, " +
                                           "ediId = @ediId " +
                                           "where livId = @livId";

                _comandoSQL.Parameters.Add("@livId", SqlDbType.Int).Value = livro.Id;
                _comandoSQL.Parameters.Add("@livNome", SqlDbType.VarChar).Value = livro.Nome;
                _comandoSQL.Parameters.Add("@livAnoPubli", SqlDbType.Int).Value = livro.AnoPublicacao;
                _comandoSQL.Parameters.Add("@livObserv", SqlDbType.VarChar).Value = livro.Observacao;
                _comandoSQL.Parameters.Add("@livSbn", SqlDbType.Int).Value = livro.SBN;
                _comandoSQL.Parameters.Add("@ediId", SqlDbType.Int).Value = livro.Editora;

            _comandoSQL.ExecuteNonQuery();

                Conexao.FecharConexao();

            }
        public void Excluir(int livro)
            {
                //delete
                _connSQL = Conexao.ObterConexao();
                _comandoSQL = new SqlCommand();
                _comandoSQL.Connection = _connSQL;
                _comandoSQL.CommandText = "delete from TblLivro where livId = @livId";

                _comandoSQL.Parameters.Add("@livId", SqlDbType.Int).Value = livro;
                _comandoSQL.ExecuteNonQuery();
                Conexao.FecharConexao();

            }
        public DataTable ListasLivros()
        {
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "select livId, livNome, livAnoPubli, livSbn, livObserv, ediId " +
            " from TblLivro " +
            " order by livId asc";


                
            _Tabela = new DataTable();
            _Adaptador = new SqlDataAdapter(_comandoSQL);
            _Adaptador.Fill(_Tabela);

            Conexao.FecharConexao();

             return _Tabela;
            }

        /*public List<Editora> ListarTodasEditora()
            {

            }*/
    }

}



