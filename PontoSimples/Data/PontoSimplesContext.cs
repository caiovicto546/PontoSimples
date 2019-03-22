using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PontoSimples.Models;

namespace PontoSimples.Models
{
    public class PontoSimplesContext : DbContext
    {
        public PontoSimplesContext (DbContextOptions<PontoSimplesContext> options)
            : base(options)
        {
        }

        public DbSet<PontoSimples.Models.Horario> Horarios { get; set; }
        public DbSet<PontoSimples.Models.Setor> Setores { get; set; }
        public DbSet<PontoSimples.Models.Funcionario> Funcionarios { get; set; }
    }
}
