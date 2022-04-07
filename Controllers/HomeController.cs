using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Intex.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Intex.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Intex.Controllers
{
    public class HomeController : Controller
    {
        private ICrashRepository repo { get; set; }

        public HomeController(ICrashRepository cr)
        {
            repo = cr;
        }
        

        // Index page that takes crash id
        public IActionResult Index()
        {
            return View();
        }

//summary
        public IActionResult Summary(string searching, int pageNum = 1)
        {

            int pageSize = 50;

            ViewBag.PageNum = pageNum;
            ViewBag.TotalPages = (repo.Crashes.Count() / pageSize);

            var cvm = new CrashesViewModel
            {
                Crashes = repo.Crashes
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize).Where(x=> x.City.Contains(searching) || x.County_Name.Contains(searching) || x.Crash_Severity_Id.Contains(searching) || searching == null)
            }; //city, county, severity

            //Where(x => x.City.Contains(searching) || x.County_Name.Contains(searching) || searching == null).ToList())

            return View(cvm);

        }

//search functinoality 
        public IActionResult Search(string searching)
        {  
            return View(repo.Crashes.Where(x => x.City.Contains(searching) || x.County_Name.Contains(searching) || x.Crash_Severity_Id.Contains(searching) || searching == null).ToList());
        }


        // Admin page with CRUD funcionality
        [Authorize]
        public IActionResult AdminTable(int pageNum = 1)
        {
            int pageSize = 50;

            ViewBag.PageNum = pageNum;
            ViewBag.TotalPages = (repo.Crashes.Count() / pageSize);

            var cvm = new CrashesViewModel
            {
                Crashes = repo.Crashes
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize)
            };

            return View(cvm);

        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        
        // Create a crash
        [HttpPost]
        public IActionResult Create(Crash c)
        {
            repo.CreateCrash(c);
            return RedirectToAction("AdminTable", 0);
        }
        

        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var crash = repo.Crashes.FirstOrDefault(x => x.Crash_Id == id);
            return View(crash);
        }

        // Edit crash
        [HttpPost]
        public IActionResult Edit(Crash c)
        {
            repo.SaveCrash(c);
            return RedirectToAction("AdminTable", 0);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var crash = repo.Crashes.FirstOrDefault(x => x.Crash_Id == id);
            return View(crash);
        }

        // Delete crash
        [HttpPost]
        public IActionResult Delete(Crash c)
        {
            repo.DeleteCrash(c);
            return RedirectToAction("AdminTable", 0);
        }

        public IActionResult Details(int crashId)
        {
            var crash = repo.Crashes
                .FirstOrDefault(x => x.Crash_Id == crashId);
            return View(crash);
        }
    }
}
