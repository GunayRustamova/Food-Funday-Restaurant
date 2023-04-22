using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.DAL;
using Restaurant.Models;
using Restaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            About about = _db.Abouts.First();
            List<Team> teams = _db.Teams.ToList();


            HomeVM homeVM = new HomeVM
            {
                About = about, 
                Teams = teams
            };


            return View(homeVM);
        }

        
        public IActionResult Error()
        {
            return View();
        }
    }
}
