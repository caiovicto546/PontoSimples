using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using PagedList.Mvc;
using Rotativa;
using Rotativa.AspNetCore;
using PontoSimples.Models;
using PontoSimples.Services;
using PontoSimples.Data;
using PontoSimples.Models.ViewModels;

namespace PontoSimples.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly PontoSimplesContext _context;
        private readonly FuncionarioService _funcionarioService;
        private readonly PontoService _pontoService;

        public RelatoriosController(FuncionarioService funcionarioService, PontoSimplesContext context, PontoService pontoService)
        {
            _funcionarioService = funcionarioService;
            _context = context;
            _pontoService = pontoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PrePrintFuncionarios()
        {
            return View(await _funcionarioService.FindAllAsync());
        }

        //public async Task<IActionResult> PrintFuncionarios()
        //{
        //    var relatorioPDF = new ViewAsPdf
        //    {
        //        ViewName = "Index",
        //        Model = Funcionario.ToPagedList
        //    };

        //    return relatorioPDF;
        //    string customSwitches = string.Format("--header-center \"TESTE DE CABEÇALHO\" " +
        //        "--header-spacing \"8\" " +
        //        "--header-font-name \"Open Sans\" " +
        //        "--footer-font-size \"8\" " +
        //        "--footer-font-name \"Open Sans\" " +
        //        "--header-font-size \"10\" " +
        //        "--footer-right \"Pag: [page] de [toPage]\"");

        //    var p = new ViewAsPdf(await _funcionarioService.FindAllAsync());

        //    p = new PartialViewResult
        //    {
        //        ViewName = "PrintFuncionarios",
        //        RotativaOptions = { CustomSwitches = customSwitches },
        //        CustomSwitches = customSwitches,
        //        PageMargins = new Rotativa.AspNetCore.Options.Margins(30, 10, 15, 10)
        //    };

        //    return p;
        //}

        public ActionResult PrintFuncionarios()
        {
            var listaFuncionarios = _context.Funcionarios.ToList();

            int pagNumero = 1;

            string customSwitches = string.Format("--header-left \"LISTA DE FUNCIONARIOS CADASTRADOS\" " +
                    "--header-spacing \"8\" " +
                    "--header-font-name \"Open Sans\" " +
                    "--footer-font-size \"10\" " +
                    "--footer-font-name \"Open Sans\" " +
                    "--header-font-size \"10\" " +
                    "--footer-right \"Pag: [page] de [toPage]\"");


            var relatorioPDF = new ViewAsPdf
            {
                ViewName = "PrintFuncionarios",
                IsGrayScale = true,
                Model = listaFuncionarios.ToPagedList(pagNumero, listaFuncionarios.Count),
                CustomSwitches = customSwitches,
                PageMargins = new Rotativa.AspNetCore.Options.Margins(30, 10, 15, 10)
            };
            return relatorioPDF;
        }



        public async Task<IActionResult> PrePrintSearch()
        {
            var funcionario = await _funcionarioService.FindAllAsync();
            var viewModel = new PontoFormViewModel { Funcionarios = funcionario };
            return View(viewModel);
        }



        public async Task<IActionResult> PrintSearch(int idFunc, DateTime? minDate, DateTime? maxDate)
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

            int pagNumero = 1;

            string customSwitches = string.Format("--header-left \"MARCAÇÕES DE PONTO\" " +
                    "--header-spacing \"8\" " +
                    "--header-font-name \"Open Sans\" " +
                    "--footer-font-size \"10\" " +
                    "--footer-font-name \"Open Sans\" " +
                    "--header-font-size \"10\" " +
                    "--footer-right \"Pag: [page] de [toPage]\"");

            var relatorioPDF = new ViewAsPdf
            {
                ViewName = "PrintSearch",
                IsGrayScale = true,
                CustomSwitches = customSwitches,
                Model = result.ToPagedList(pagNumero, result.Count),
                PageMargins = new Rotativa.AspNetCore.Options.Margins(30, 10, 15, 10)
            };

            return relatorioPDF;
        }
    }
}