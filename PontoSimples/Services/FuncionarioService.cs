using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using PontoSimples.Models;
using PontoSimples.Services.Exception;

namespace PontoSimples.Services
{
    public class FuncionarioService
    {
        private readonly PontoSimplesContext _context;

        public FuncionarioService(PontoSimplesContext context)
        {
            _context = context;
        }

        public async Task<List<Funcionario>> FindAllAsync()
        {
            return await _context.Funcionarios.ToListAsync();
        }

        public async Task InsertAsync(Funcionario obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Funcionario> FindByIdAsync(int id)
        {
            return await _context.Funcionarios.Include(obj => obj.Setor).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Funcionarios.FindAsync(id);
                _context.Funcionarios.Remove(obj);
                await _context.SaveChangesAsync();
            }

            catch(DbUpdateException e)
            {
                throw new ExcecaoDeIntegridade(e.Message);
            }
        }

        public async Task UpdateAsync(Funcionario obj)
        {
            bool hasany = await _context.Funcionarios.AnyAsync(x => x.Id == obj.Id);

            if (!hasany)
            {
                throw new ExcecaoNotFound("Funcionario não encontrado");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (ExcecaoConcorrencia e)
            {
                throw new ExcecaoConcorrencia(e.Message);
            }
        }
    }
}
