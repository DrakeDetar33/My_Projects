using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCRecipeBook.Data;
using MVCRecipeBook.Models;

namespace MVCRecipeBook.Controllers
{
    public class RecipeBookModelsController : Controller
    {
        private readonly MVCRecipeBookContext _context;

        public RecipeBookModelsController(MVCRecipeBookContext context)
        {
            _context = context;
        }

        // GET: RecipeBookModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.RecipeBookModel.ToListAsync());
        }

        // GET: RecipeBookModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipeBookModel = await _context.RecipeBookModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (recipeBookModel == null)
            {
                return NotFound();
            }

            return View(recipeBookModel);
        }

        // GET: RecipeBookModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RecipeBookModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Ingredients,Calories,Protien,Carbohydrates,Fat")] RecipeBookModel recipeBookModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipeBookModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recipeBookModel);
        }

        // GET: RecipeBookModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipeBookModel = await _context.RecipeBookModel.FindAsync(id);
            if (recipeBookModel == null)
            {
                return NotFound();
            }
            return View(recipeBookModel);
        }

        // POST: RecipeBookModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Ingredients,Calories,Protien,Carbohydrates,Fat")] RecipeBookModel recipeBookModel)
        {
            if (id != recipeBookModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipeBookModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeBookModelExists(recipeBookModel.ID))
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
            return View(recipeBookModel);
        }

        // GET: RecipeBookModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recipeBookModel = await _context.RecipeBookModel
                .FirstOrDefaultAsync(m => m.ID == id);
            if (recipeBookModel == null)
            {
                return NotFound();
            }

            return View(recipeBookModel);
        }

        // POST: RecipeBookModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recipeBookModel = await _context.RecipeBookModel.FindAsync(id);
            _context.RecipeBookModel.Remove(recipeBookModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipeBookModelExists(int id)
        {
            return _context.RecipeBookModel.Any(e => e.ID == id);
        }
    }
}
