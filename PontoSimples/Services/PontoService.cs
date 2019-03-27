using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


    }
}
