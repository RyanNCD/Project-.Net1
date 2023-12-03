using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class ProjectDAO
    {
        private static ProjectDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProjectDAO() { }
        public static ProjectDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProjectDAO();
                    }
                    return instance;
                }
            }
        }


        public List<ProjectObject> projectList = new List<ProjectObject>();
        public List<ProjectObject> Read => projectList.OrderByDescending(s => s.ProjectName).ToList();

        public ProjectObject GetProjectByID(string projectID) 
        {
            ProjectObject project = projectList.SingleOrDefault(pr => pr.ProjectID == projectID);
            return project;
        }
        public void Create(ProjectObject proj)
        {
            ProjectObject pr = GetProjectByID(proj.ProjectID);
            if (pr == null)
            {
                projectList.Add(proj);
            }
            else
            {
                throw new Exception("This Project is exist!!!");
            }
        }
        public void Delete(string projectID) { 
            ProjectObject p = GetProjectByID(projectID);
            if (p != null)
            {
                projectList.Remove(p);
            }
            else
            {
                throw new Exception("This Project is not exist!!!");
            }
        }
        public void Update(ProjectObject proj)
        {
            ProjectObject pr = GetProjectByID(proj.ProjectID);
            if (pr != null)
            {
                var index = projectList.IndexOf(pr);
                projectList[index] = proj;
            }
            
        }
    }
}
