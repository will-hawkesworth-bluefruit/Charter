using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterLibrary
{
    public class SectionModel
    {
        public string sectionName { get; set; }
        public int sectionID { get; set; }
        public string sectionDescription { get; set; }
        public string sectionTestingRating { get; set; }

        public string sectionTestingScore { get; set; }
        public List<CharterModel> sectionCharters { get; set; }
    }
}
