using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class CpfInvalidoException : Exception
    {
        public CpfInvalidoException(string mensagem) :base(mensagem) { }
    }
}
