using BusinessObjects;
using DataAccessObjects;
using BusinessObjects;
using System;
using System.Collections.Generic;

namespace Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public void DeleteProject(string projectID) => ProjectDAO.Instance.Delete(projectID);
        public ProjectObject GetProjectById(string projectId) => ProjectDAO.Instance.GetProjectByID(projectId);

        public IEnumerable<ProjectObject> GetProjects() => ProjectDAO.Instance.Read;
        public void CreateProject(ProjectObject project) => ProjectDAO.Instance.Create(project);

        public void UpdateProject(ProjectObject project) => ProjectDAO.Instance.Update(project);
    }
}
