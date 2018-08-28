using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToolCatalog.Models
{
    public class MockToolRepository : IToolRepository
    {
        private readonly ICountryRepository _countryRepository = new MockCountryRepository();
        public IEnumerable<Tool> NewestTool
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<Tool> Tools
        {
            get
            {
                return new List<Tool>
                {
                    new Tool {IdTool=1, Name = "4Oczy", CurrentVersion="1.0.0", DateOfCreated = DateTime.Now, Manual = "", Path = "", Tag = "test, test2",  Country = _countryRepository.Countries.ToList()[0],ImageUrl="http://www.lrsc.edu/Image%20Library/LakeRegion/Academic/Term%20Schedules/excel-icon.png", ImageThumbnailUrl="http://www.lrsc.edu/Image%20Library/LakeRegion/Academic/Term%20Schedules/excel-icon.png"},
                    new Tool {IdTool=2, Name = "MassHR", CurrentVersion="1.1.0", DateOfCreated = DateTime.Now, Manual = "", Path = "", Tag = "test, test2", Country = _countryRepository.Countries.ToList()[0],ImageUrl="http://www.lrsc.edu/Image%20Library/LakeRegion/Academic/Term%20Schedules/excel-icon.png", ImageThumbnailUrl="http://www.lrsc.edu/Image%20Library/LakeRegion/Academic/Term%20Schedules/excel-icon.png"},
                    new Tool {IdTool=3, Name = "4Oczy", CurrentVersion="1.0.0", DateOfCreated = DateTime.Now, Manual = "", Path = "", Tag = "test, test2",  Country = _countryRepository.Countries.ToList()[1],ImageUrl="http://www.lrsc.edu/Image%20Library/LakeRegion/Academic/Term%20Schedules/excel-icon.png", ImageThumbnailUrl="http://www.lrsc.edu/Image%20Library/LakeRegion/Academic/Term%20Schedules/excel-icon.png"},
                    new Tool {IdTool=4, Name = "MassHR", CurrentVersion="1.1.0", DateOfCreated = DateTime.Now, Manual = "", Path = "", Tag = "test, test2", Country = _countryRepository.Countries.ToList()[1],ImageUrl="http://www.lrsc.edu/Image%20Library/LakeRegion/Academic/Term%20Schedules/excel-icon.png", ImageThumbnailUrl="http://www.lrsc.edu/Image%20Library/LakeRegion/Academic/Term%20Schedules/excel-icon.png"}

                };
            }
        }

        public Tool GetToolById(int toolId)
        {
            throw new NotImplementedException();
        }
    }
}
