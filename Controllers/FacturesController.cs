using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Garderie.Models;

namespace Garderie.Controllers
{
    public class FacturesController : Controller
    {
        private readonly GarderieContext _context;

        public FacturesController(GarderieContext context)
        {
            _context = context;
        }

        // GET: Factures
        public async Task<IActionResult> Index()
        {
            var factures = from f in _context.Factures.Include(f => f.StatutFacture)
                           select f;
            factures = factures.Where(f => f.Visible == 1);
            return View(await factures.ToListAsync());
        }

        // GET: Factures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facture = await _context.Factures
                .Include(f => f.StatutFacture)
                .FirstOrDefaultAsync(m => m.FactureId == id);
            if (facture == null)
            {
                return NotFound();
            }

            return View(facture);
        }

        // GET: Factures/Create
        public IActionResult Create()
        {
            ViewData["StatutFactureId"] = new SelectList(_context.StatutsFacture, "StatutFactureId", "Libelle");
            return View();
        }

        // POST: Factures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FactureId,DateEmission,DatePaiement,MontantTtc,Visible,StatutFactureId")] Facture facture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(facture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StatutFactureId"] = new SelectList(_context.StatutsFacture, "StatutFactureId", "Libelle", facture.StatutFactureId);
            return View(facture);
        }

        // GET: Factures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facture = await _context.Factures.FindAsync(id);
            if (facture == null)
            {
                return NotFound();
            }
            ViewData["StatutFactureId"] = new SelectList(_context.StatutsFacture, "StatutFactureId", "Libelle", facture.StatutFactureId);
            return View(facture);
        }

        // POST: Factures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FactureId,DateEmission,DatePaiement,MontantTtc,Visible,StatutFactureId")] Facture facture)
        {
            if (id != facture.FactureId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(facture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FactureExists(facture.FactureId))
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
            ViewData["StatutFactureId"] = new SelectList(_context.StatutsFacture, "StatutFactureId", "Libelle", facture.StatutFactureId);
            return View(facture);
        }

        // GET: Factures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var facture = await _context.Factures
                .Include(f => f.StatutFacture)
                .FirstOrDefaultAsync(m => m.FactureId == id);
            if (facture == null)
            {
                return NotFound();
            }

            return View(facture);
        }

        // POST: Factures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var facture = await _context.Factures.FindAsync(id);
            _context.Factures.Remove(facture);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FactureExists(int id)
        {
            return _context.Factures.Any(e => e.FactureId == id);
        }
    }
}
