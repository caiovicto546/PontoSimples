using System.Collections.Generic;

namespace PontoSimples.Models.ViewModels
{
    public class FuncionarioFormViewModel
    {
        public Funcionario Funcionario { get; set; }
        public ICollection<Setor> Setores { get; set; }
        public ICollection<Horario> Horarios { get; set; }
    }
}
