using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Garderie.Models;
using Garderie.Data;

namespace Test.Controllers
{
    public class EnfantsController : Controller
    {
        private readonly GarderieContext _context;

        public EnfantsController(GarderieContext context)
        {
            _context = context;
        }

        // GET: Enfants
        public async Task<IActionResult> Index()
        {
            var garderieContext = _context.Enfants
                                          .Include(e => e.Groupe)
                                          .Include(e => e.Groupe.TypeGroupe)
                                          .Include(e => e.InventaireEnfant)
                                          .Include(e => e.Personne);
            return View(await garderieContext.ToListAsync());
        }

        // GET: Enfants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfant = await _context.Enfants
                .Include(e => e.Groupe)
                .Include(e => e.Groupe.TypeGroupe)
                .Include(e => e.InventaireEnfant)
                .Include(e => e.Personne)
                .FirstOrDefaultAsync(m => m.EnfantId == id);
            if (enfant == null)
            {
                return NotFound();
            }

            return View(enfant);
        }

        // GET: Enfants/Create
        public IActionResult Create()
        {
            ViewData["GroupeId"] = new SelectList(_context.Groupes, "GroupeId", "GroupeId");
            ViewData["InventaireEnfantId"] = new SelectList(_context.InventairesEnfant, "InventaireId", "InventaireId");
            return View();
        }

        // POST: Enfants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnfantId,Photo,GroupeId,InventaireEnfantId")] Enfant enfant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enfant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupeId"] = new SelectList(_context.Groupes, "GroupeId", "GroupeId", enfant.GroupeId);
            ViewData["InventaireEnfantId"] = new SelectList(_context.InventairesEnfant, "InventaireId", "InventaireId", enfant.InventaireEnfantId);
            return View(enfant);
        }

        // GET: Enfants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfant = await _context.Enfants.FindAsync(id);
            if (enfant == null)
            {
                return NotFound();
            }
            ViewData["GroupeId"] = new SelectList(_context.Groupes, "GroupeId", "GroupeId", enfant.GroupeId);
            ViewData["InventaireEnfantId"] = new SelectList(_context.InventairesEnfant, "InventaireId", "InventaireId", enfant.InventaireEnfantId);
            return View(enfant);
        }

        // POST: Enfants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnfantId,Photo,GroupeId,InventaireEnfantId")] Enfant enfant)
        {
            if (id != enfant.EnfantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enfant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnfantExists(enfant.EnfantId))
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
            ViewData["GroupeId"] = new SelectList(_context.Groupes, "GroupeId", "GroupeId", enfant.GroupeId);
            ViewData["InventaireEnfantId"] = new SelectList(_context.InventairesEnfant, "InventaireId", "InventaireId", enfant.InventaireEnfantId);
            return View(enfant);
        }

        // GET: Enfants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enfant = await _context.Enfants
                .Include(e => e.Groupe)
                .Include(e => e.InventaireEnfant)
                .FirstOrDefaultAsync(m => m.EnfantId == id);
            if (enfant == null)
            {
                return NotFound();
            }

            return View(enfant);
        }

        // POST: Enfants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enfant = await _context.Enfants.FindAsync(id);
            _context.Enfants.Remove(enfant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnfantExists(int id)
        {
            return _context.Enfants.Any(e => e.EnfantId == id);
        }
    }
}
