using System.Collections;
using System.Collections.Generic;
using BL;
using D.UI.MVC.Models;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace D.UI.MVC.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectManager projectMgr;
        private IIdeationManager ideationMgr;
        
        public ProjectController()
        {
            projectMgr = new ProjectManager();
            ideationMgr = new IdeationManager();
        }
        
      
        public IActionResult Projects()
        {
            IEnumerable<Project> allProjects = projectMgr.getProjects();
            return View(allProjects);
        }

        public IActionResult Project(int id)
        {
            Project p1 = projectMgr.getProject(id);
            IEnumerable<IdeationQuestion> ideationQuestions1 = ideationMgr.getIdeationQuestions(id);
            var model = new ProjectAndQuestions() {ideationQuestions = ideationQuestions1, project = p1};

            return View(model);
        }

        public IActionResult Ideas(int id)
        {
            IEnumerable <Idea>  ideas = ideationMgr.getIdeas(id);
            return View(ideas);
        }
    }
}