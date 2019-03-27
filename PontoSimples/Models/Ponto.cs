﻿using System;
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
        [Column("marc_ponto")]
        public DateTime Marcacao { get; set; }

        public Ponto()
        {
        }

        public Ponto(Funcionario funcionario, DateTime marcacao)
        {
            Funcionario = funcionario;
            Marcacao = marcacao;
        }


    }
}
