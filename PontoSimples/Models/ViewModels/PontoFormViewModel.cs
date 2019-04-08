using System.Collections.Generic;

namespace PontoSimples.Models.ViewModels
{
    public class PontoFormViewModel
    {
        public Ponto Ponto { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}
