using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PontoSimples.Models;

namespace PontoSimples.Services
{
    public class PontoService
    {
        private readonly PontoSimplesContext _context;

        public PontoService(PontoSimplesContext context)
        {
            _context = context;
        }

        public async Task InsertAsync(Ponto ponto)
        {
            _context.Add(ponto);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Ponto>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Pontos select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Marcacao >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Marcacao <= maxDate.Value);
            }

            return await result.Include(x => x.Funcionario).OrderBy(x => x.Marcacao).ToListAsync();
        }
    }
}
