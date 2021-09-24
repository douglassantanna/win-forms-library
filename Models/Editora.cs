using System;

namespace Models
{
    public class Editora
    {
        private int _id;
        private string _nome;
        private string _sigla;
        private string _observacao;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Sigla
        {
            get { return _sigla; }
            set { _sigla = value; }
        }
        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }
    }
}
