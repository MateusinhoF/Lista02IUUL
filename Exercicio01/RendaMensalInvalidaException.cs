using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class RendaMensalInvalidaException : Exception
    {
        public RendaMensalInvalidaException(string mensagem) : base(mensagem) { }
    }
}
