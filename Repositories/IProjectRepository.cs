using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public  interface IProjectRepository
    {
        IEnumerable<ProjectObject> GetProjects();
        ProjectObject GetProjectById(String projectID);
        void DeleteProject(string project);
        void CreateProject(ProjectObject project);
        void UpdateProject(ProjectObject project);
    }
}
