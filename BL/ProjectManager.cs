using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BL.Managers;
using DAL;
using Domain;

namespace BL
{
    public class ProjectManager : IProjectManager
    {
        private IProjectRepository repo;

        public ProjectManager() 
        {
            repo = new ProjectRepository();
        }

        public ProjectManager(UnitOfWorkManager unitOfWorkManager)
        {
            if (unitOfWorkManager == null)
            {
                throw new ArgumentException("unitOfWorkManager");
            }
            repo = new ProjectRepository(unitOfWorkManager.UnitOfWork);
        }
        
        public IEnumerable<Project> getProjects()
        {
            return repo.readProjects();
        }

        public Project getProject(int id)
        {
            return repo.readProject(id);
        }

        public IEnumerable<Questionnaire> getQuestionnaires()
        {
            return repo.readQuestionnaires();
        }

        public Project addProject(int projectId)
        {
            Project project = this.getProject(projectId);
            this.changeProject(project);

            return project;
        }
        
        public void addProject(Project p)
        {
            repo.createProject(p);
        }

        public void changeProject(Project p)
        {
            Validator.ValidateObject(p, new ValidationContext(p));
            repo.updateProject(p);
        }

        public void removeProject(int id)
        {
            repo.deleteProject(id);
        }
    }
}