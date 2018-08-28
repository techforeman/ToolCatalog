using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToolCatalog.Models
{
    public class SSCUnitRepository : ISSCUnitRepository
    {
        private readonly AppDbContext _appDbContext;

        public SSCUnitRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<SSCUnit> SSCUnits => _appDbContext.SSCUnits;

        
    }
}
