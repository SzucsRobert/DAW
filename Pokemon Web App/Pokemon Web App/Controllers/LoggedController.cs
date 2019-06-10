using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokemon_Web_App.Data;
using Pokemon_Web_App.Models;

namespace Pokemon_Web_App.Controllers
{
    public class LoggedController : Controller
    {
        private readonly PokemonAppContext _context;

        public LoggedController(PokemonAppContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            return View();
        }
        public IActionResult Privacy()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            return View();
        }

        public async Task<IActionResult> YourTeam()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            string accountname = Convert.ToString(HttpContext.Session.GetString("UserName"));

            Account CurrentAccount = await _context.AccountTable
                .FirstOrDefaultAsync(m => m.Username == accountname);
            if(CurrentAccount.TeamID == Guid.Empty) 
            {
                return RedirectToAction("ChooseTeam");
            }

            Team team = await _context.TeamTable
                .FirstOrDefaultAsync(m => m.ID == CurrentAccount.TeamID);
            return View(team);
        }

        public async Task<IActionResult> ChooseTeam()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            return View(await _context.TeamTable.ToListAsync());
        }


        public async Task<IActionResult> AddTeam(Guid? id)
        {
            if (id == null || HttpContext.Session.GetString("UserName") == null)
            {
                return NotFound();
            }
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            if (id != null)
            {
                string accountname = Convert.ToString(HttpContext.Session.GetString("UserName"));

                Account CurrentAccount = await _context.AccountTable
                    .FirstOrDefaultAsync(m => m.Username == accountname);

                CurrentAccount.TeamID =(Guid)id;
                _context.SaveChanges();
            }
            return RedirectToAction("YourTeam");
        }

    }
}