using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Autore
    {
        private int _id;
        private string _nome;
        private string _pseudomino;
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
        public string Pseudomino
        {
            get { return _pseudomino; }
            set { _pseudomino = value; }
        }
        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }
    }
}
