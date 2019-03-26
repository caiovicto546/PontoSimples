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

        public void ConverteHoraMinuto(DateTime marcAtual)
        {
            marcAtual = DateTime.Now;
            int minutos = int.Parse(marcAtual.ToString("hh:mm")) * 60;
        }

        public async Task InsertAsync(Ponto ponto)
        {
            ConverteHoraMinuto(ponto.Marcacao);
            _context.Add(ponto);
            await _context.SaveChangesAsync();
        }


    }
}
