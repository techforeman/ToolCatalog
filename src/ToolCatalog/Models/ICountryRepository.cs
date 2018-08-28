using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToolCatalog.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> Countries { get; }
        //Country GetCountryNameById(int countryId);

    }
}
