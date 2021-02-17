using IS413Assignment5Real.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IS413Assignment5Real.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //makes private repository of type ibooks
        private IBooksRepository _repository;

        public HomeController(ILogger<HomeController> logger,IBooksRepository repository)
        {
            // home controller constructor guy has attribute _repository which is repository
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
                return View(_repository.Books);
            }
            else
            {
                return View();
            }
        }

        public IActionResult BookList()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
