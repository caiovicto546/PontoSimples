using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Models.ViewModels
{
    public class PontoFormViewModel
    {
        public Ponto Ponto { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}
