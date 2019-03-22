using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PontoSimples.Models
{
    [Serializable]
    [Table("Setores")]
    public class Setor
    {
        [Column("id_setor")]
        public int Id { get; set; }
        [Column("cod_setor")]
        [Display(Name = "Código do Setor")]
        public string CodigoSetor { get; set; }
        [Column("nome_setor")]
        [Display(Name = "Nome do Setor")]
        public string NomeSetor { get; set; }

        public Setor()
        {
        }

        public Setor(string codigoSetor, string nomeSetor)
        {
            CodigoSetor = codigoSetor;
            NomeSetor = nomeSetor;
        }
    }
}
