using System.Collections.Generic;

namespace CharterLibrary
{
    public class ProjectModel
    {
        public static object ProjetName { get; set; }
        public string projectName { get; set; }
        public int projectID { get; set; }
        public string projectDescription { get; set; }
        public List<SectionModel> projectSections { get; set; }
    }
}