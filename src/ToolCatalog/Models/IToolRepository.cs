using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToolCatalog.Models
{
    public interface IToolRepository
    {
        IEnumerable<Tool> Tools { get; }
        IEnumerable<Tool> NewestTool { get; }

        Tool GetToolById(int toolId);
    }
}
