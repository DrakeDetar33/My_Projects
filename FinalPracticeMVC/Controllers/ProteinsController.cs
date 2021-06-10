using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalPracticeMVC.Data;
using FinalPracticeMVC.Models;

namespace FinalPracticeMVC.Controllers
{
    public class ProteinsController : Controller
    {
        private readonly FinalPracticeMVCContext _context;

        public ProteinsController(FinalPracticeMVCContext context)
        {
            _context = context;
        }

        // GET: Proteins
        /*
        public async Task<IActionResult> Index()
        {
            return View(await _context.Protein.ToListAsync());
        }
        */
        public async Task<IActionResult> Index(string animalProtein, string searchString) {
            IQueryable<string> animalQuery = from p in _context.Protein
                                             orderby p.Animal
                                             select p.Animal;
            var animals = from p in _context.Protein
                          select p;


        }
        // GET: Proteins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Proteins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Animal,Name,ServingSize,ProteinTot,FatTot,Calories")] Protein protein)
        {
            if (ModelState.IsValid)
            {
                _context.Add(protein);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(protein);
        }

        // GET: Proteins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var protein = await _context.Protein.FindAsync(id);
            if (protein == null)
            {
                return NotFound();
            }
            return View(protein);
        }

        // POST: Proteins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Animal,Name,ServingSize,ProteinTot,FatTot,Calories")] Protein protein)
        {
            if (id != protein.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(protein);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProteinExists(protein.ID))
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
            return View(protein);
        }

        // GET: Proteins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var protein = await _context.Protein
                .FirstOrDefaultAsync(m => m.ID == id);
            if (protein == null)
            {
                return NotFound();
            }

            return View(protein);
        }

        // POST: Proteins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var protein = await _context.Protein.FindAsync(id);
            _context.Protein.Remove(protein);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProteinExists(int id)
        {
            return _context.Protein.Any(e => e.ID == id);
        }
    }
}
