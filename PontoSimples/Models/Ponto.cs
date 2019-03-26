using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Models
{
    
    public class Ponto
    {
        public int IdPonto { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime DataMarcacao { get; set; }
        public DateTime Marcacao { get; set; }

        public Ponto()
        {
        }

        public Ponto(int idPonto, Funcionario funcionario, DateTime dataMarcacao, DateTime marcacao)
        {
            IdPonto = idPonto;
            Funcionario = funcionario;
            DataMarcacao = dataMarcacao;
            Marcacao = marcacao;
        }

        public Ponto(Funcionario funcionario, DateTime dataMarcacao, DateTime marcacao)
        {
            Funcionario = funcionario;
            DataMarcacao = dataMarcacao;
            Marcacao = marcacao;
        }


    }
}
