using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PontoSimples.Models;

namespace PontoSimples.Data
{
    public class PontoSimplesContext : DbContext
    {
        public PontoSimplesContext(DbContextOptions<PontoSimplesContext> options)
            : base(options)
        {
        }

        public PontoSimplesContext()
        {
        }

        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Ponto> Pontos { get; set; }
    }    
}
