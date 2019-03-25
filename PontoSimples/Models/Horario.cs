﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Models
{
    [Serializable]
    [Table("horarios")]
    public class Horario
    {
        [Column("id_horario")]
        public int Id { get; set; }
        [Column("cod_horario")]
        [Display(Name = "Código")]
        public string Codigo { get; set; }
        [Column("desc_horario")]
        [Display(Name = "Descrição do Horário")]
        public string Descricao { get; set; }
        [Column("hora_inicio")]
        [Display(Name = "Hora Inicio")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:MM}")]
        public DateTime HoraInicio { get; set; }
        [Column("hora_fim")]
        [Display(Name = "Hora Fim")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:MM}")]
        public DateTime HoraFim { get; set; }
        [Column("inicio_almoco")]
        [Display(Name = "Inicio Almoço")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:MM}")]
        public DateTime InicioAlmoco { get; set; }
        [Column("fim_almoco")]
        [Display(Name = "Fim Almoço")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:MM}")]
        public DateTime FimAlmoco { get; set; }

        public Horario()
        {
        }

        public Horario(int id, string codigo, string descricao, DateTime horaInicio, DateTime inicioAlmoco, DateTime fimAlmoco, DateTime horaFim)
        {
            Id = id;
            Codigo = codigo;
            Descricao = descricao;
            HoraInicio = horaInicio;
            InicioAlmoco = inicioAlmoco;
            FimAlmoco = fimAlmoco;
            HoraFim = horaFim;
        }

        public Horario(string codigo, string descricao, DateTime horaInicio, DateTime inicioAlmoco, DateTime fimAlmoco, DateTime horaFim)
        {
            Codigo = codigo;
            Descricao = descricao;
            HoraInicio = horaInicio;
            InicioAlmoco = inicioAlmoco;
            FimAlmoco = fimAlmoco;
            HoraFim = horaFim;
        }
    }
}
