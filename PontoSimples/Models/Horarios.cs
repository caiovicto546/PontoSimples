using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontoSimples.Models
{
    public class Horarios
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }
        public DateTime InicioAlmoco { get; set; }
        public DateTime FimAlmoco { get; set; }

        public Horarios()
        {
        }

        public Horarios(int id, int codigo, DateTime horaInicio, DateTime inicioAlmoco, DateTime fimAlmoco, DateTime horaFim)
        {
            Id = id;
            Codigo = codigo;
            HoraInicio = horaInicio;
            InicioAlmoco = inicioAlmoco;
            FimAlmoco = fimAlmoco;
            HoraFim = horaFim;
        }

        public Horarios(int codigo, DateTime horaInicio, DateTime inicioAlmoco, DateTime fimAlmoco, DateTime horaFim)
        {
            Codigo = codigo;
            HoraInicio = horaInicio;
            InicioAlmoco = inicioAlmoco;
            FimAlmoco = fimAlmoco;
            HoraFim = horaFim;
        }
    }
}
