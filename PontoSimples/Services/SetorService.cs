using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PontoSimples.Models;
using PontoSimples.Services.Exception;

namespace PontoSimples.Services
{
    public class SetorService
    {
        private readonly PontoSimplesContext _context;

        public SetorService(PontoSimplesContext context)
        {
            _context = context;
        }

        public async Task<List<Setor>> FindAllAsync()
        {
            return await _context.Setores.OrderBy(x => x.NomeSetor).ToListAsync();
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Setores.FindAsync(id);
                _context.Setores.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {

                throw new ExcecaoDeIntegridade(e.Message);
            }
            
        }
    }
}
