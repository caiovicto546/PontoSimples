using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PontoSimples.Models;
using PontoSimples.Controllers;
using PontoSimples.Services.Exception;

namespace PontoSimples.Services
{
    public class LoginService
    {
        private readonly PontoSimplesContext _context;

        public LoginService(PontoSimplesContext context)
        {
            _context = context;
        }

        public async Task<List<Login>> ValidaUsuarioAsync(string usuario, string senha)
        {
            var result = _context.Logins.Select(x => x);

            try
            {
                result = result.Where(x => x.Usuario == usuario);
                result = result.Where(x => x.Senha == senha);
                return await result.ToListAsync();
            }
            catch (System.Exception)
            {

                throw new ExcecaoDeIntegridade("Usuário ou senha não definidos no Banco de Dados");
            }            
        }
    }
}
