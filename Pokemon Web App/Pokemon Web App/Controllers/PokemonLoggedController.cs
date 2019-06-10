using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pokemon_Web_App.Data;
using Pokemon_Web_App.Models;

namespace Pokemon_Web_App.Controllers
{
    public class PokemonLoggedController : Controller
    {
        private readonly PokemonAppContext _context;

        public PokemonLoggedController(PokemonAppContext context)
        {
            _context = context;
        }

        // GET: PokemonLogged
        public async Task<IActionResult> Index()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            return View(await _context.PokemonTable.ToListAsync());
        }

        // GET: PokemonLogged/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            if (id == null)
            {
                return NotFound();
            }

            var pokemon = await _context.PokemonTable
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // GET: PokemonLogged/Create
        public IActionResult Create()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            return View();
        }

        // POST: PokemonLogged/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Height,Weight,Gender,Category,Type,Abilities,ImageLocation")] Pokemon pokemon)
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            if (ModelState.IsValid)
            {
                pokemon.ID = Guid.NewGuid();
                _context.Add(pokemon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pokemon);
        }

        // GET: PokemonLogged/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            if (id == null)
            {
                return NotFound();
            }

            var pokemon = await _context.PokemonTable.FindAsync(id);
            if (pokemon == null)
            {
                return NotFound();
            }
            return View(pokemon);
        }

        // POST: PokemonLogged/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,Name,Height,Weight,Gender,Category,Type,Abilities,ImageLocation")] Pokemon pokemon)
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            if (id != pokemon.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pokemon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PokemonExists(pokemon.ID))
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
            return View(pokemon);
        }

        // GET: PokemonLogged/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            if (id == null)
            {
                return NotFound();
            }

            var pokemon = await _context.PokemonTable
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pokemon == null)
            {
                return NotFound();
            }

            return View(pokemon);
        }

        // POST: PokemonLogged/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            var pokemon = await _context.PokemonTable.FindAsync(id);
            _context.PokemonTable.Remove(pokemon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PokemonExists(Guid id)
        {
            return _context.PokemonTable.Any(e => e.ID == id);
        }
    }
}
