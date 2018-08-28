using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToolCatalog.Models
{
    public class SSCUnit
    {
        [Key]
        public int IdSSCUnit { get; set; }
        public string SSCName { get; set; }
        public string UnitName { get; set; }
        public List<Tool> Tools { get; set; }
    }
}
