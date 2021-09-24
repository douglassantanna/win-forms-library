using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class editoraDAL
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
            _comandoSQL.CommandText = "select isnull(max(ediId), 0) + 1 as ediId " +
                                       "from tblEditoras";
            Id = int.Parse(_comandoSQL.ExecuteScalar().ToString());
            Conexao.FecharConexao();

            return Id;
        }
        public void Salvar(Editora editora)
        {
            //insert
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "insert into tblEditoras (ediId, ediNome, edSigla, edObserv)" +
                                                    "values (@ediId, @ediNome, @edSigla, @edObserv)";

            _comandoSQL.Parameters.Add("@ediId", SqlDbType.Int).Value = editora.Id;
            _comandoSQL.Parameters.Add("@ediNome", SqlDbType.VarChar).Value = editora.Nome;
            _comandoSQL.Parameters.Add("@edSigla", SqlDbType.VarChar).Value = editora.Sigla;
            _comandoSQL.Parameters.Add("@edObserv", SqlDbType.VarChar).Value = editora.Observacao;
            _comandoSQL.ExecuteNonQuery();

            Conexao.FecharConexao();
        }
        public void Atualizar(Editora editora)
        {
            //update
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "update tblEditoras" +
                                       "set ediNome = @ediNome, " +
                                       "edSigla = @edSigla, " +
                                       "edObserv = @edObserv, " +
                                       "where ediId = @ediId";

            _comandoSQL.Parameters.Add("@ediId", SqlDbType.Int).Value = editora.Id;
            _comandoSQL.Parameters.Add("@ediNome", SqlDbType.VarChar).Value = editora.Nome;
            _comandoSQL.Parameters.Add("@edSigla", SqlDbType.VarChar).Value = editora.Sigla;
            _comandoSQL.Parameters.Add("@edObserv", SqlDbType.VarChar).Value = editora.Observacao;
            _comandoSQL.ExecuteNonQuery();

            Conexao.FecharConexao();

        }
        public void Excluir(int editora)
        {
            //delete
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "delete from tblEditoras where ediId = @ediId";

            _comandoSQL.Parameters.Add("@ediId", SqlDbType.Int).Value = editora;
            _comandoSQL.ExecuteNonQuery();
            Conexao.FecharConexao();

        }
        public DataTable ListarEditoras()
        {
            //select
            _connSQL = Conexao.ObterConexao();
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _connSQL;
            _comandoSQL.CommandText = "select ediId ,ediNome ,edSigla ,edObserv " +
            " from tblEditoras " +
            " order by ediId asc";

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
