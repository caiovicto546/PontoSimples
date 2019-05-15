using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using PontoSimples.Models;
using PontoSimples.Services;

namespace PontoSimples.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly FuncionarioService _funcionarioService;
        private readonly SetorService _setorService;
        private readonly HorarioService _horarioService;

        public RelatoriosController(FuncionarioService funcionarioService, SetorService setorService, HorarioService horarioService)
        {
            _funcionarioService = funcionarioService;
            _setorService = setorService;
            _horarioService = horarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PrintFuncionarios()
        {
            return new ViewAsPdf(await _funcionarioService.FindAllAsync());
        }
    }
}