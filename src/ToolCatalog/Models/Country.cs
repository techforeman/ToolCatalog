using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToolCatalog.Models
{
    public class Country
    {
        [Key]
        public int IdCountry { get; set; }
        public string CountryName { get; set; }
        public List<Tool> Tools { get; set; }
    }
}
