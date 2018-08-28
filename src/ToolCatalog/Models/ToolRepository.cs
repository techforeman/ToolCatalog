using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolCatalog.Models;

namespace ToolCatalog.Models
{
    public class ToolRepository : IToolRepository
    {
        private readonly AppDbContext _appDbContext;
        public ToolRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Tool> NewestTool
        {
            get
            {
                return _appDbContext.Tools.Include(c => c.Country).Where(n => n.IsNew);
            }
        }

        public IEnumerable<Tool> Tools
        {
            get
            {
                return _appDbContext.Tools.Include(c => c.Country);
            }
        }

        public Tool GetToolById(int toolId)
        {
            return _appDbContext.Tools.FirstOrDefault(t => t.IdTool == toolId);
        }
    }
}
