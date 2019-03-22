using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PontoSimples.Models;


namespace PontoSimples.Services
{
    public class HorarioService
    {
        private readonly PontoSimplesContext _context;

        public HorarioService(PontoSimplesContext context)
        {
            _context = context;
        }

        public async Task<List<Horario>> FindAllAsync()
        {
            return await _context.Horarios.OrderBy(x => x.Codigo).ToListAsync();
        }
    }
}
