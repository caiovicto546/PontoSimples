using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PontoSimples.Models
{
    public class PontoSimplesContext : DbContext
    {
        public PontoSimplesContext (DbContextOptions<PontoSimplesContext> options)
            : base(options)
        {
        }

        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Ponto> Pontos { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
