using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokemon_Web_App.Data;
using Pokemon_Web_App.Models;

namespace Pokemon_Web_App.Controllers
{
    public class AccountController : Controller
    {

        private readonly PokemonAppContext _context;


        public AccountController(PokemonAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(Account account)
        {
            //HttpContext.Session.SetString("UserName", "qwe");
            if (ModelState.IsValid)
            {
                _context.Add(account);
                _context.SaveChanges();
                ModelState.Clear();
                return RedirectToAction(nameof(SuccesfullyRegistered));
            }
            return View();
        }

        public IActionResult SuccesfullyRegistered()
        {
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(Account acc)
        {
            if (acc.Username != null && acc.Password != null)
            {
                var searchforacc = _context.AccountTable.Where(a => a.Username.Equals(acc.Username) && a.Password.Equals(acc.Password)).FirstOrDefault();
                if (searchforacc != null)
                {
                    HttpContext.Session.SetString("UserName", searchforacc.Username);
                    HttpContext.Session.SetString("Password", acc.Password);

                    return RedirectToAction("UserDashBoard");
                }
                else
                {
                    return RedirectToAction("SignIn");
                }
            }
            return RedirectToAction("Login");

        }
        public ActionResult UserDashBoard()
        {
            return RedirectToAction("Index", "Logged");
        }

        public ActionResult SignOut(Account acc)
        {
            if (HttpContext.Session.GetString("UserName") != null && HttpContext.Session.GetString("Password") != null)
            {
                HttpContext.Session.SetString("UserName", "");
                HttpContext.Session.SetString("Password", "");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}