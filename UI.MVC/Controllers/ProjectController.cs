using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        public IActionResult MapTest()
        {
            return View();
        }
     /*   public IActionResult ImageTest()
        {
            ImageField x = new ImageField();
            return View(x);
        }*/
        
        
        
        public ActionResult ImageTest()
        {
            Idea idea = ideationMgr.getIdea(19);
           // Field[] fields = idea.fields.ToArray();
           var fields = idea.fields.ToArray();
           ICollection<ImageField> imageFields = new List<ImageField>();
           
           foreach (var imagefield in fields)
           {
             imageFields.Add((ImageField)imagefield);
           }
           //ImageField imageField =  (ImageField)fields[0];
       
                     
            
            
          //  var base64 = Convert.ToBase64String(imageField.data);
         //   var imgSrc = String.Format("data:image/png;base64,{0}", base64);

         //   ViewBag.ImageData = imgSrc;
            return View(imageFields);
        }
    }
}