using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToolCatalog.Models
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CountryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Country> Countries => _appDbContext.Countries;

        //public Country GetCountryNameById(int countryId)
        //{
        //    return _appDbContext.Countries.First(c => c.IdCountry == countryId);
        //}
    }
}
