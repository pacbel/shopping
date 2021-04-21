using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Main.Models;

namespace Main.Controllers
{
    public class IndiceMonetariosController : Controller
    {
        private readonly Context _context;

        public IndiceMonetariosController(Context context)
        {
            _context = context;
        }

        // GET: IndiceMonetarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Indices.ToListAsync());
        }

        // GET: IndiceMonetarios/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indiceMonetario = await _context.Indices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (indiceMonetario == null)
            {
                return NotFound();
            }

            return View(indiceMonetario);
        }

        // GET: IndiceMonetarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IndiceMonetarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NomeIndice,CodBancoCentral,Id,Ativo,DataLog")] IndiceMonetario indiceMonetario)
        {
            if (ModelState.IsValid)
            {
                indiceMonetario.Id = Guid.NewGuid();
                _context.Add(indiceMonetario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(indiceMonetario);
        }

        // GET: IndiceMonetarios/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indiceMonetario = await _context.Indices.FindAsync(id);
            if (indiceMonetario == null)
            {
                return NotFound();
            }
            return View(indiceMonetario);
        }

        // POST: IndiceMonetarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("NomeIndice,CodBancoCentral,Id,Ativo,DataLog")] IndiceMonetario indiceMonetario)
        {
            if (id != indiceMonetario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indiceMonetario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndiceMonetarioExists(indiceMonetario.Id))
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
            return View(indiceMonetario);
        }

        // GET: IndiceMonetarios/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indiceMonetario = await _context.Indices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (indiceMonetario == null)
            {
                return NotFound();
            }

            return View(indiceMonetario);
        }

        // POST: IndiceMonetarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var indiceMonetario = await _context.Indices.FindAsync(id);
            _context.Indices.Remove(indiceMonetario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndiceMonetarioExists(Guid id)
        {
            return _context.Indices.Any(e => e.Id == id);
        }
    }
}
