﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class DataNascimentoInvalidaException : Exception
    {
        public DataNascimentoInvalidaException(string mensagem) : base(mensagem) { }
    }
}
