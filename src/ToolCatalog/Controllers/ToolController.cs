using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToolCatalog.Models;
using ToolCatalog.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ToolCatalog.Controllers
{
    public class ToolController : Controller
    {
        private readonly  IToolRepository _toolRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly ISSCUnitRepository _sscunitRepository;

        public ToolController(IToolRepository toolRepository, ICountryRepository countryRepository, ISSCUnitRepository sscunitRepository)
        {
            _toolRepository = toolRepository;
            _countryRepository = countryRepository;
            _sscunitRepository = sscunitRepository;

        }

        public ViewResult List(string ssc, string unit,string country)
        {

            IEnumerable<Tool> tools;
            string currentCountry = string.Empty;
            string currentssc = string.Empty;
            string currentunit = string.Empty;

            if (string.IsNullOrEmpty(country))
            {
                tools = _toolRepository.Tools.OrderBy(p => p.IdTool);
                currentCountry = "All countries";
            }
            else
            {
                tools = _toolRepository.Tools.Where(p => p.Country.CountryName == country)
                        .Where(s=>s.SSCUnit.SSCName == ssc)
                        .Where(u=>u.SSCUnit.UnitName == unit)
                    .OrderBy(p => p.IdCountry);
                currentCountry = _countryRepository.Countries.FirstOrDefault(c => c.CountryName==country).CountryName;
                currentssc = _sscunitRepository.SSCUnits.FirstOrDefault(s => s.SSCName == ssc).SSCName;
                currentunit = _sscunitRepository.SSCUnits.FirstOrDefault(u => u.UnitName == unit).UnitName;
            }
            
            return View(new ToolListViewModel
            {
                Tools = tools,
                CountryName = currentCountry,
                SSCName = "POZ",
                UnitName = "HR"


            });

            //ToolListViewModel toolListViewModel = new ToolListViewModel();
            //toolListViewModel.Tools = _toolRepository.Tools;
            //toolListViewModel.CountryName = "PL";
           
            //return View(toolListViewModel);
        }
        public IActionResult Details(int id)
        {
            var tool = _toolRepository.GetToolById(id);
            if (tool == null)
                return NotFound();
            return View(tool);
        }

        
        private List<ToolListViewModel> GetListedTools()
        {

            List<ToolListViewModel> listedTools = new List<ToolListViewModel>();
            return listedTools;
        }


        public ActionResult ListedTools()
        {
            var listedTools = GetListedTools();
            return Json(listedTools);
        }

    }
}
