using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToolCatalog.Models
{
    public interface ISSCUnitRepository
    {
        IEnumerable<SSCUnit> SSCUnits { get; }
    }
}
