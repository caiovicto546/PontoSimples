using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Models
{
    [Serializable]
    [Table("funcionarios")]
    public class Funcionario
    {
        [Column("id_func")]
        public int Id { get; set; }
        [Column("matr_func")]
        [Required(ErrorMessage = "Matricula obrigatória!")]
        public int Matricula { get; set; }
        [Column("nome_func")]
        [Required(ErrorMessage = "Nome obrigatório!")]
        public string Nome { get; set; }
        [Display(Name = "Setor")]
        public Setor Setor { get; set; }
        [Column("id_setor")]
        [Display(Name = "Setor")]
        [Required(ErrorMessage = "Setor obrigatório!")]
        public int SetorId { get; set; }
        [Column("pis_func")]
        [Required(ErrorMessage = "PIS do funcionário obrigatório!")]
        public int PIS { get; set; }
        [Display(Name = "Horário")]
        public Horario HoraFunc { get; set; }
        [Column("id_horario")]
        [Display(Name = "Horário")]
        [Required(ErrorMessage = "Horário obrigatório!")]
        public int HoraFuncId { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(int matricula, string nome, Setor setor, int pIS, Horario horaFunc)
        {
            Matricula = matricula;
            Nome = nome;
            Setor = setor;
            PIS = pIS;
            HoraFunc = horaFunc;
        }
    }
}
