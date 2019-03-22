using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Models.ViewModels
{
    public class FuncionarioFormViewModel
    {
        public Funcionario Funcionarios { get; set; }
        public ICollection<Setor> Setores { get; set; }
        public ICollection<Horario> Horarios { get; set; }
    }
}
