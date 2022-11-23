using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class EstadoCivilInvalidoException : Exception
    {
        public EstadoCivilInvalidoException(string mensagem)
            : base(mensagem)
        { }
    }
}
