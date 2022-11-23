using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class DependentesInvalidoException : Exception
    {
        public DependentesInvalidoException(string mensagem)
            :base(mensagem)
        { }
    }
}
