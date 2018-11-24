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
    public class GroupesController : Controller
    {
        private readonly GarderieContext _context;

        public GroupesController(GarderieContext context)
        {
            _context = context;
        }

        // GET: Groupes
        public async Task<IActionResult> Index()
        {
            var garderieContext = _context.Groupes.Include(g => g.Referant).Include(g => g.TypeGroupe);
            return View(await garderieContext.ToListAsync());
        }

        // GET: Groupes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupe = await _context.Groupes
                .Include(g => g.Referant)
                .Include(g => g.TypeGroupe)
                .FirstOrDefaultAsync(m => m.GroupeId == id);
            if (groupe == null)
            {
                return NotFound();
            }

            return View(groupe);
        }

        // GET: Groupes/Create
        public IActionResult Create()
        {
            ViewData["ReferantId"] = new SelectList(_context.Employes, "EmployeId", "EmployeId");
            ViewData["TypeGroupeId"] = new SelectList(_context.TypesGroupe, "TypeGroupeId", "TypeGroupeId");
            return View();
        }

        // POST: Groupes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GroupeId,Descriptif,ReferantId,Visible,TypeGroupeId")] Groupe groupe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groupe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ReferantId"] = new SelectList(_context.Employes, "EmployeId", "EmployeId", groupe.ReferantId);
            ViewData["TypeGroupeId"] = new SelectList(_context.TypesGroupe, "TypeGroupeId", "TypeGroupeId", groupe.TypeGroupeId);
            return View(groupe);
        }

        // GET: Groupes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupe = await _context.Groupes.FindAsync(id);
            if (groupe == null)
            {
                return NotFound();
            }
            ViewData["ReferantId"] = new SelectList(_context.Employes, "EmployeId", "EmployeId", groupe.ReferantId);
            ViewData["TypeGroupeId"] = new SelectList(_context.TypesGroupe, "TypeGroupeId", "TypeGroupeId", groupe.TypeGroupeId);
            return View(groupe);
        }

        // POST: Groupes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GroupeId,Descriptif,ReferantId,Visible,TypeGroupeId")] Groupe groupe)
        {
            if (id != groupe.GroupeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groupe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroupeExists(groupe.GroupeId))
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
            ViewData["ReferantId"] = new SelectList(_context.Employes, "EmployeId", "EmployeId", groupe.ReferantId);
            ViewData["TypeGroupeId"] = new SelectList(_context.TypesGroupe, "TypeGroupeId", "TypeGroupeId", groupe.TypeGroupeId);
            return View(groupe);
        }

        // GET: Groupes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groupe = await _context.Groupes
                .Include(g => g.Referant)
                .Include(g => g.TypeGroupe)
                .FirstOrDefaultAsync(m => m.GroupeId == id);
            if (groupe == null)
            {
                return NotFound();
            }

            return View(groupe);
        }

        // POST: Groupes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groupe = await _context.Groupes.FindAsync(id);
            _context.Groupes.Remove(groupe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroupeExists(int id)
        {
            return _context.Groupes.Any(e => e.GroupeId == id);
        }
    }
}
