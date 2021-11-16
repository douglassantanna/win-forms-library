namespace Models
{
    public class Usuario
    {
        private int _codigo;
        private string _nome;
        private string _email;
        private string _senha;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
    }
}
