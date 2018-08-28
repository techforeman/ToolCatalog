using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToolCatalog.Models
{
    public class Tool
    {
        [Key]
        public int IdTool { get; set; }
        public string Name { get; set; }
        public string CurrentVersion { get; set; }
        public string Tag { get; set; }
        public string Path { get; set; }
        public string Manual { get; set; }

        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public DateTime DateOfCreated { get; set; }
        public bool IsNew { get; set; }

        public bool IsActive { get; set; }

        public int IdCountry { get; set; }
        public virtual Country Country { get; set; }

        public int IdSSCUnit { get; set; }
        public virtual SSCUnit SSCUnit { get; set; }
    }   

}
