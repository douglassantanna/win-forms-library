using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Livro
    {
        private int _id;
        private string _nome;
        private int _anoPublicacao;
        private int _sbn;
        private string _observacao;
        private int _editora;

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
        public int AnoPublicacao
        {
            get { return _anoPublicacao; }
            set { _anoPublicacao = value; }
        }
        public int SBN
        {
            get { return _sbn; }
            set { _sbn = value; }
        }
        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }
        public int Editora
        {
            get { return _editora; }
            set { _editora = value; }
        }
    }
}
