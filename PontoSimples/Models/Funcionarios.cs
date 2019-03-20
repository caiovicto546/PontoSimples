using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Models
{
    public class Funcionarios
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Setor { get; set; }
        public int PIS { get; set; }
        public Horarios HoraFunc { get; set; }

        public Funcionarios()
        {
        }

        public Funcionarios(int matricula, string nome, string setor, int pIS, Horarios horaFunc)
        {
            Matricula = matricula;
            Nome = nome;
            Setor = setor;
            PIS = pIS;
            HoraFunc = horaFunc;
        }
    }
}
