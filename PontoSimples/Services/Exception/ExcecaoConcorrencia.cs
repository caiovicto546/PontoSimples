using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Services.Exception
{
    public class ExcecaoConcorrencia : ApplicationException
    {
        public ExcecaoConcorrencia(string message) : base(message)
        {
        }
    }
}
