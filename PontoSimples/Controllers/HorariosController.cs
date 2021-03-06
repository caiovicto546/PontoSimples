﻿using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PontoSimples.Models;
using PontoSimples.Models.ViewModels;
using PontoSimples.Services;
using PontoSimples.Services.Exception;
using PontoSimples.Data;
using Microsoft.AspNetCore.Authorization;

namespace PontoSimples.Controllers
{
    public class HorariosController : Controller
    {
        private readonly PontoSimplesContext _context;
        private readonly HorarioService _horarioService;

        //public HorariosController(PontoSimplesContext context)
        //{
        //    _context = context;
        //}

        public HorariosController(PontoSimplesContext context, HorarioService horarioService)
        {
            _context = context;
            _horarioService = horarioService;
        }

        //public HorariosController(HorarioService horarioService)
        //{
        //    _horarioService = horarioService;
        //}





        // GET: Horarios
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Horarios.ToListAsync());
        }

        // GET: Horarios/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horarios = await _context.Horarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (horarios == null)
            {
                return NotFound();
            }

            return View(horarios);
        }

        // GET: Horarios/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Horarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Id,Codigo,Descricao,HoraInicio,HoraFim,InicioAlmoco,FimAlmoco")] Horario horarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(horarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(horarios);
        }

        // GET: Horarios/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horarios = await _context.Horarios.FindAsync(id);
            if (horarios == null)
            {
                return NotFound();
            }
            return View(horarios);
        }

        // POST: Horarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,Descricao,HoraInicio,HoraFim,InicioAlmoco,FimAlmoco")] Horario horarios)
        {
            if (id != horarios.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(horarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HorariosExists(horarios.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(horarios);
        }

        // GET: Horarios/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horarios = await _context.Horarios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (horarios == null)
            {
                return NotFound();
            }

            return View(horarios);
        }

        // POST: Horarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _horarioService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (ExcecaoDeIntegridade)
            {
                return RedirectToAction(nameof(Error), new { message = "Impossível deletar. Horário já está vinculado a algum funcionário." });
            }
            
        }

        private bool HorariosExists(int id)
        {
            return _context.Horarios.Any(e => e.Id == id);
        }

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
