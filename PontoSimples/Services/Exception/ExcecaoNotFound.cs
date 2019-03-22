using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Services.Exception
{
    public class ExcecaoNotFound : ApplicationException
    {
        public ExcecaoNotFound(string message) : base(message)
        {
        }
    }
}
