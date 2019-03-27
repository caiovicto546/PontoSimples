using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PontoSimples.Services;
using PontoSimples.Models.ViewModels;
using PontoSimples.Models;

namespace PontoSimples.Controllers
{
    public class PontosController : Controller
    {
        private readonly PontoService _pontoService;
        private readonly FuncionarioService _funcionarioService;

        public PontosController(PontoService pontoService, FuncionarioService funcionarioService)
        {
            _pontoService = pontoService;
            _funcionarioService = funcionarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //GET
        public async Task<IActionResult> Create()
        {
            var funcionario = await _funcionarioService.FindAllAsync();
            var viewModel = new PontoFormViewModel { Funcionarios = funcionario };
            return View(viewModel);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Ponto ponto)
        {
            /*if (!ModelState.IsValid)
            {
                var funcionario = await _funcionarioService.FindAllAsync();
                var viewModel = new PontoFormViewModel { Ponto = ponto, Funcionarios = funcionario };
                return View(viewModel);
            }*/
            ponto.Marcacao = DateTime.Now;
            await _pontoService.InsertAsync(ponto);
            return RedirectToAction(nameof(Index));
        }

    }
}