using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras
{
    public abstract class RegrasAbstratas
    {
        public abstract void Salvar(Object parObjeto);
        public abstract void Excluir(int parCodigo);
        public abstract void Atualizar(Object parObjeto);
        public abstract DataTable ListarDados();
    }
}
