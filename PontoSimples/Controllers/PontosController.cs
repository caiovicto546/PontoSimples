using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PontoSimples.Services;
using PontoSimples.Models.ViewModels;
using PontoSimples.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public async Task<IActionResult> Index()
        {
            var funcionario = await _funcionarioService.FindAllAsync();
            var viewModel = new PontoFormViewModel { Funcionarios = funcionario };
            return View(viewModel);
        }

        public IActionResult ConfirmPonto()
        {
            return View(nameof(Create));
        }

        //GET
        public async Task<IActionResult> Create()
        {
            var funcionario = await _funcionarioService.FindAllAsync();
            PontoFormViewModel viewModel = new PontoFormViewModel { Funcionarios = funcionario };
            return View(viewModel);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Ponto ponto)
        {
            if (!ModelState.IsValid)
            {
                var funcionario = await _funcionarioService.FindAllAsync();
                var viewModel = new PontoFormViewModel { Ponto = ponto, Funcionarios = funcionario };
                return View(viewModel);
            }
            ponto.Marcacao = DateTime.Now;
            await _pontoService.InsertAsync(ponto);
            //return View(nameof(ConfirmPonto));
            return RedirectToAction(nameof(Create));
        }

        //Busca das Marcações
        public async Task<IActionResult> Search(int idFunc, DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("dd-MM-yyyy");
            ViewData["maxDate"] = maxDate.Value.ToString("dd-MM-yyyy");
            ViewData["idFunc"] = idFunc.ToString();

            var result = await _pontoService.FindByDateAsync(idFunc, minDate, maxDate);
            return View(result);
        }

    }
}