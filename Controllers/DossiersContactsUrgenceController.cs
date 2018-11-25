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
    public class DossiersContactsUrgenceController : Controller
    {
        private readonly GarderieContext _context;

        public DossiersContactsUrgenceController(GarderieContext context)
        {
            _context = context;
        }

        // GET: DossiersContactsUrgence
        public async Task<IActionResult> Index()
        {
            var garderieContext = _context.DossiersContactUrgence.Include(d => d.Contact).Include(d => d.DossierInscription);
            return View(await garderieContext.ToListAsync());
        }

        // GET: DossiersContactsUrgence/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dossierContactUrgence = await _context.DossiersContactUrgence
                .Include(d => d.Contact)
                .Include(d => d.DossierInscription)
                .FirstOrDefaultAsync(m => m.DossierContactUrgenceId == id);
            if (dossierContactUrgence == null)
            {
                return NotFound();
            }

            return View(dossierContactUrgence);
        }

        // GET: DossiersContactsUrgence/Create
        public IActionResult Create()
        {
            ViewData["ContactId"] = new SelectList(_context.ContactsUrgence, "ContactId", "ContactId");
            ViewData["DossierInscriptionId"] = new SelectList(_context.DossiersInscription, "DossierId", "DossierId");
            return View();
        }

        // POST: DossiersContactsUrgence/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DossierContactUrgenceId,LienParente,ContactId,Visible,DossierInscriptionId")] DossierContactUrgence dossierContactUrgence)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dossierContactUrgence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContactId"] = new SelectList(_context.ContactsUrgence, "ContactId", "ContactId", dossierContactUrgence.ContactId);
            ViewData["DossierInscriptionId"] = new SelectList(_context.DossiersInscription, "DossierId", "DossierId", dossierContactUrgence.DossierInscriptionId);
            return View(dossierContactUrgence);
        }

        // GET: DossiersContactsUrgence/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dossierContactUrgence = await _context.DossiersContactUrgence.FindAsync(id);
            if (dossierContactUrgence == null)
            {
                return NotFound();
            }
            ViewData["ContactId"] = new SelectList(_context.ContactsUrgence, "ContactId", "ContactId", dossierContactUrgence.ContactId);
            ViewData["DossierInscriptionId"] = new SelectList(_context.DossiersInscription, "DossierId", "DossierId", dossierContactUrgence.DossierInscriptionId);
            return View(dossierContactUrgence);
        }

        // POST: DossiersContactsUrgence/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DossierContactUrgenceId,LienParente,ContactId,Visible,DossierInscriptionId")] DossierContactUrgence dossierContactUrgence)
        {
            if (id != dossierContactUrgence.DossierContactUrgenceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dossierContactUrgence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DossierContactUrgenceExists(dossierContactUrgence.DossierContactUrgenceId))
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
            ViewData["ContactId"] = new SelectList(_context.ContactsUrgence, "ContactId", "ContactId", dossierContactUrgence.ContactId);
            ViewData["DossierInscriptionId"] = new SelectList(_context.DossiersInscription, "DossierId", "DossierId", dossierContactUrgence.DossierInscriptionId);
            return View(dossierContactUrgence);
        }

        // GET: DossiersContactsUrgence/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dossierContactUrgence = await _context.DossiersContactUrgence
                .Include(d => d.Contact)
                .Include(d => d.DossierInscription)
                .FirstOrDefaultAsync(m => m.DossierContactUrgenceId == id);
            if (dossierContactUrgence == null)
            {
                return NotFound();
            }

            return View(dossierContactUrgence);
        }

        // POST: DossiersContactsUrgence/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dossierContactUrgence = await _context.DossiersContactUrgence.FindAsync(id);
            _context.DossiersContactUrgence.Remove(dossierContactUrgence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DossierContactUrgenceExists(int id)
        {
            return _context.DossiersContactUrgence.Any(e => e.DossierContactUrgenceId == id);
        }
    }
}
