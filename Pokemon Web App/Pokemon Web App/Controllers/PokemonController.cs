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
    public class PokemonController : Controller
    {
        private readonly PokemonAppContext _context;

        public PokemonController(PokemonAppContext context)
        {
            _context = context;
        }

        // GET: Pokemons
        public async Task<IActionResult> Index()
        {
            return View(await _context.PokemonTable.ToListAsync());
        }

        // GET: Pokemons/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
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

        

        private bool PokemonExists(Guid id)
        {
            return _context.PokemonTable.Any(e => e.ID == id);
        }
    }
}
