using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToolCatalog.Models
{
    public class MockCountryRepository : ICountryRepository
    {
        public IEnumerable<Country> Countries
        {
            get
            {
                return new List<Country>
                {
                    new Country { IdCountry=1, CountryName="PL"},
                    new Country { IdCountry=2, CountryName="SL" }
                };
            }
        }
    }
}
