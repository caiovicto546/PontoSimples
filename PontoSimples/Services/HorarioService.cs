using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PontoSimples.Models;
using PontoSimples.Services.Exception;
using PontoSimples.Data;

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

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Horarios.FindAsync(id);
                _context.Horarios.Remove(obj);
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateException e)
            {
                throw new ExcecaoDeIntegridade(e.Message);
            }
        }
    }
}
