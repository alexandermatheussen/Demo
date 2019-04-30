using System.Collections.Generic;
using BL;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace D.UI.MVC.Controllers.Api
{
    public class ProjectsController : Controller
    {
        IProjectManager mgr = new ProjectManager();
        
        [HttpGet("/api/Projects")]
        public IActionResult GetProjects()
        {
            IEnumerable<Project> projects = mgr.getProjects();
            return Ok(projects);
        }
        
        [HttpGet("/api/Projects/{id}")]
        public IActionResult GetProject(int id)
        {
            //Either you add a service in startup.cs to ignore reference loop handling
            //or you comment/delete the 'include' line in the project repository
            Project project = mgr.getProject(id);
            return Ok(project);
        }
    }
}