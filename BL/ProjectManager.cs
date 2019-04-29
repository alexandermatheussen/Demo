using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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

        public Idea getIdea(int ideaId)
        {
            return repo.readIdea(ideaId);
        }

        public IEnumerable<Report> getReports(int ideaId)
        {
            return repo.readReportsOfIdea(ideaId);
        }

        public Report addReport(int ideaId, string reportMessage)
        {
            Idea idea = getIdea(ideaId);

            if (idea != null)
            {
                Report newReport = new Report();
                newReport.idea = idea;
                newReport.dateSubmitted = DateTime.Now;
                newReport.reportMessage = reportMessage;

                var reports = getReports(ideaId);

                if (reports != null)
                {
                    idea.reports = reports.ToList();
                }
                else
                {
                    idea.reports = new List<Report>();
                }

                idea.reports.Add(newReport);

                repo.createReport(newReport);
                repo.updateIdea(idea);

                return newReport;
            }
            
            throw new ArgumentException("ideaId " + ideaId + " not found!");
            
        }
    }
}