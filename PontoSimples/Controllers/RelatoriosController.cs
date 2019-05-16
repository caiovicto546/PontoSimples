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

namespace PontoSimples.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly PontoSimplesContext _context;
        private readonly FuncionarioService _funcionarioService;

        public RelatoriosController(FuncionarioService funcionarioService, PontoSimplesContext context)
        {
            _funcionarioService = funcionarioService;
            _context = context;
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




        //private PontoSimplesContext db = new PontoSimplesContext();
        public ActionResult PrintFuncionarios(int? pagina, Boolean? pdf)
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
    }
}