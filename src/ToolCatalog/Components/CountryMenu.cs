using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolCatalog.Models;

namespace ToolCatalog.Components
{
    public class CountryMenu : ViewComponent
    {
        private readonly ICountryRepository _countryRepository;

        public CountryMenu(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var countries = _countryRepository.Countries.OrderBy(c => c.CountryName);
            return View(countries);
        }

    }
}
