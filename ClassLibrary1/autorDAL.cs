using Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class autorDAL
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
            _comandoSQL.CommandText = "select isnull(max(autId ), 0) + 1 as autId   " +
                                       "from tblAutores  ";
            Id = int.Parse(_comandoSQL.ExecuteScalar().ToString());
            Conexao.FecharConexao();

            return Id;
        }
        public void Salvar(Autore Parautor)
        {
            try
            {
                //insert
                _connSQL = Conexao.ObterConexao();
                _comandoSQL = new SqlCommand();
                _comandoSQL.Connection = _connSQL;
                _comandoSQL.CommandText = "insert into tblAutores  (autId, autNome, autPseudomino, autObserv)" +
                                                        "values (@autId, @autNome, @autPseudomino, @autObserv)";

                _comandoSQL.Parameters.Add("@autId", SqlDbType.Int).Value = Parautor.Id;
                _comandoSQL.Parameters.Add("@autNome", SqlDbType.VarChar).Value = Parautor.Nome;
                _comandoSQL.Parameters.Add("@autPseudomino", SqlDbType.VarChar).Value = Parautor.Pseudomino;
                _comandoSQL.Parameters.Add("@autObserv", SqlDbType.VarChar).Value = Parautor.Observacao;

                _comandoSQL.ExecuteNonQuery();

                Conexao.FecharConexao();
            }
            
            catch (Exception ex)
            {
                 throw new Exception("AutorDAL: " + ex.Message);
            }
        }
        public void Atualizar(Autore autor)
        {
            //update
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "update tblAutores " +
                                       "set autNome = @autNome, " +
                                       "autPseudomino = @autPseudomino, " +
                                       "autObserv = @autObserv " +
                                       "where autId = @autId";

            _comandoSQL.Parameters.Add("@autId", SqlDbType.Int).Value = autor.Id;
            _comandoSQL.Parameters.Add("@autNome", SqlDbType.VarChar).Value = autor.Nome;
            _comandoSQL.Parameters.Add("@autPseudomino", SqlDbType.VarChar).Value = autor.Pseudomino;
            _comandoSQL.Parameters.Add("@autObserv", SqlDbType.VarChar).Value = autor.Observacao;

            _comandoSQL.ExecuteNonQuery();

            Conexao.FecharConexao();

        }
        public void Excluir(int autor)
        {
            //delete
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "delete from tblAutores where autId = @autId";

            _comandoSQL.Parameters.Add("@autId", SqlDbType.Int).Value = autor;
            _comandoSQL.ExecuteNonQuery();
            Conexao.FecharConexao();

        }
        public DataTable ListarAutores()
        {
            //select
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "select autId, autNome, autPseudomino, autObserv  " +
            " from tblAutores  " +
            " order by autId asc";

            _Tabela = new DataTable();
            _Adaptador = new SqlDataAdapter(_comandoSQL);
            _Adaptador.Fill(_Tabela);

            Conexao.FecharConexao();

            return _Tabela;
        }
    }
}
    


