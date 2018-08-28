using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToolCatalog.Models;
using ToolCatalog.ViewModels;

namespace ToolCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IToolRepository _toolRepository;

        public HomeController(IToolRepository toolRepository)
        {
            _toolRepository = toolRepository;
        }
        public ViewResult Index( )
        {
            var homeViewModel = new HomeViewModel
            {
                ToolsAreNew = _toolRepository.NewestTool
            };
            return View(homeViewModel);
        }

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact us";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
