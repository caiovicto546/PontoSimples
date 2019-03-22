using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Services.Exception
{
    public class ExcecaoDeIntegridade : ApplicationException
    {
        public ExcecaoDeIntegridade(string message) : base(message)
        {
        }
    }
}
