using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PontoSimples.Services;
using PontoSimples.Models.ViewModels;
using PontoSimples.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Rotativa.AspNetCore;

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

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var funcionario = await _funcionarioService.FindAllAsync();
            var viewModel = new PontoFormViewModel { Funcionarios = funcionario };
            return View(viewModel);
        }

        [Authorize]
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
        [Authorize]
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

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            ViewData["idFunc"] = idFunc.ToString();

            var result = await _pontoService.FindByDateIDAsync(idFunc, minDate, maxDate);
            return View(result);
        }

        [Authorize]
        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
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

            var result = await _pontoService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        [Authorize]
        public IActionResult PrintSearch()
        {
            var p = new ViewAsPdf("Search");

            return p;
        }
    }
}