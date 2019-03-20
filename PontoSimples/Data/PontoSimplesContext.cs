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

        public DbSet<PontoSimples.Models.Horarios> Horarios { get; set; }
    }
}
