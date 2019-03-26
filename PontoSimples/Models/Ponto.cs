using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Models
{
    [Serializable]
    [Table("ponto")]
    public class Ponto
    {
        [Column("idPonto")]
        public int Id { get; set; }
        [Display(Name = "Matricula")]
        public Funcionario Funcionario { get; set; }
        [Column("id_func")]
        [Display(Name = "Matricula")]
        public int FuncId { get; set; }
        [Column("dtMarcacao")]
        public DateTime DataMarcacao { get; set; }
        [Column("marcacaoMinutos")]
        public DateTime Marcacao { get; set; }

        public Ponto()
        {
        }

        public Ponto(int idPonto, Funcionario funcionario, int funcId, DateTime dataMarcacao, DateTime marcacao)
        {
            Id = idPonto;
            Funcionario = funcionario;
            FuncId = funcId;
            DataMarcacao = dataMarcacao;
            Marcacao = marcacao;
        }

        public Ponto(Funcionario funcionario, int funcId, DateTime dataMarcacao, DateTime marcacao)
        {
            Funcionario = funcionario;
            FuncId = funcId;
            DataMarcacao = dataMarcacao;
            Marcacao = marcacao;
        }


    }
}
