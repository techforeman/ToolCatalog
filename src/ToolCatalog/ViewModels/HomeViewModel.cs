using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolCatalog.Models;

namespace ToolCatalog.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Tool> ToolsAreNew { get; set; }

        public string CountryName { get; set; }

        public string SSCName { get; set; }
        public string UnitName { get; set; }
    }
}
