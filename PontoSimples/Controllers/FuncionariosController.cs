using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PontoSimples.Models;
using PontoSimples.Services;
using PontoSimples.Models.ViewModels;
using PontoSimples.Services.Exception;
using PontoSimples.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Authorization;

namespace PontoSimples.Controllers
{
    public class FuncionariosController : Controller
    {
        
        //private readonly PontoSimplesContext _context;
        private readonly FuncionarioService _funcionarioService;
        private readonly SetorService _setorService;
        private readonly HorarioService _horarioService;

        public FuncionariosController(PontoSimplesContext context, FuncionarioService funcionarioService, SetorService setorService, HorarioService horarioService)
        {
            //_context = context;
            _funcionarioService = funcionarioService;
            _setorService = setorService;
            _horarioService = horarioService;
        }

        // GET: Funcionarios
        [Authorize]
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Funcionarios.ToListAsync());
            return View(await _funcionarioService.FindAllAsync());
        }

        // GET: Funcionarios/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não informado" });
            }

            var funcionarios = await _funcionarioService.FindByIdAsync(id.Value);
            if (funcionarios == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado" });
            }

            return View(funcionarios);
        }

        // GET: Funcionarios/Create
        [Authorize]
        public async Task<IActionResult> Create()
        {
            var setor = await _setorService.FindAllAsync();
            var horario = await _horarioService.FindAllAsync();
            var viewModel = new FuncionarioFormViewModel { Setores = setor, Horarios = horario };
            return View(viewModel);
        }

        // POST: Funcionarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(Funcionario funcionario)
        {
            if (!ModelState.IsValid)
            {
                var setor = await _setorService.FindAllAsync();
                var horario = await _horarioService.FindAllAsync();
                var viewModel = new FuncionarioFormViewModel { Funcionario = funcionario, Setores = setor, Horarios = horario };
                return View(viewModel);
            }
            await _funcionarioService.InsertAsync(funcionario);
            return RedirectToAction(nameof(Index));
        }

        // GET: Funcionarios/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não informado" });
            }

            var funcionario = await _funcionarioService.FindByIdAsync(id.Value);
            if (funcionario == null)
            {
                return RedirectToAction(nameof(Error), new { message = "ID não encontrado" });
            }
            List<Setor> setores = await _setorService.FindAllAsync();
            List<Horario> horarios = await _horarioService.FindAllAsync();
            FuncionarioFormViewModel viewModel = new FuncionarioFormViewModel { Funcionario = funcionario, Setores = setores, Horarios = horarios };
            return View(viewModel);
        }

        // POST: Funcionarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, Funcionario funcionario)
        {
            if (!ModelState.IsValid)
            {
                var setor = await _setorService.FindAllAsync();
                var horario = await _horarioService.FindAllAsync();
                var viewModel = new FuncionarioFormViewModel { Funcionario = funcionario, Setores = setor, Horarios = horario };
                return View(viewModel);
            }

            if (id != funcionario.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "ID Não corresponde" });
            }

            try
            {
                await _funcionarioService.UpdateAsync(funcionario);
                return RedirectToAction(nameof(Index));
            }
            catch (ExcecaoNotFound e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
            catch (ExcecaoConcorrencia e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        // GET: Funcionarios/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Funcionário não informado" });
            }

            var funcionarios = await _funcionarioService.FindByIdAsync(id.Value);
            if (funcionarios == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Funcionário não encontrado" });
            }

            return View(funcionarios);
        }

        // POST: Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _funcionarioService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (ExcecaoDeIntegridade)
            {
                return RedirectToAction(nameof(Error), new { message = "Impossível deletar pois o funcionário já possui marcação." });
            }
        }

        /*{
            var funcionarios = await _context.Funcionarios.FindAsync(id);
            _context.Funcionarios.Remove(funcionarios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionariosExists(int id)
        {
            return _context.Funcionarios.Any(e => e.Id == id);
        }*/

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier //Pega o ID interno da requisição para exibir o erro corretamente.
            };

            return View(viewModel);
        }
    }
}
