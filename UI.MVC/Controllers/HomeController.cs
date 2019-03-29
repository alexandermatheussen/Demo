using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using BL;
using Microsoft.AspNetCore.Mvc;
using D.UI.MVC.Models;
using Domain;

namespace D.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly QuestionnaireManager qmgr;
        private readonly ProjectManager pmgr;

        public HomeController()
        {
            qmgr = new QuestionnaireManager();
            pmgr = new ProjectManager();
        }
        
        public IActionResult Input()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        
        public IActionResult Questionnaires(int id)
        {
            IEnumerable<Questionnaire> allQuestionnaires = qmgr.getQuestionnaires(id);
            return View(allQuestionnaires);
        }
        
        public IActionResult Questionnaire(int id)
        {
            CombinedModel combinedModel = new CombinedModel();
            combinedModel.questions = qmgr.getQuestions(id);
            return View(combinedModel);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateUserQuestion(int userId, int questionId, String answer)
        {
            userId = 1;
            questionId = 3;
            qmgr.addQuestionUser(userId, questionId, answer);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}