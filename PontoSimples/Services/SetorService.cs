using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PontoSimples.Models;

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
    }
}
