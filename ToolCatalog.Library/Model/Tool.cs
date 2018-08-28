using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolCatalog.Library.Model
{
    public class Tool
    {
        public string NameTool { get; set; }
        public string CurrentVersion { get; set; }
        public ICollection<string> PreviousVersion { get; set; }
        public string Country { get; set; }


    }
}
