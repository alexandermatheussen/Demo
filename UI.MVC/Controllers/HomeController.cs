using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using BL;
using Microsoft.AspNetCore.Mvc;
using D.UI.MVC.Models;
using Domain;
using Microsoft.AspNetCore.Http;

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
        public IActionResult CreateUserQuestion(IFormCollection form)
        {
            List<int> currentQuestionIds = new List<int>();
            var currentQuestion = 0;
            foreach (var key in form.Keys)
            {
                if (key == "questionId")
                {
                    foreach (var answer in form[key])
                    {
                        currentQuestionIds.Add(Convert.ToInt32(answer));
                    }
                }
                if (key != "__RequestVerificationToken" && key != "questionId" && !key.StartsWith("CheckBox"))
                {
                    foreach (var answer in form[key])
                    {
                        qmgr.addQuestionUser(1, currentQuestionIds[currentQuestion], answer);
                        currentQuestion++;
                    }
                }
                if (key.StartsWith("CheckBox"))
                {
                    qmgr.addQuestionUser(1, currentQuestionIds[currentQuestion], form[key]);
                    currentQuestion++;
                }
            }
            return RedirectToAction("Index");
        }
        
        /*[HttpPost]
        public IActionResult CreateUserQuestion(int userId, int questionId, String answer)
        {
            qmgr.addQuestionUser(userId, questionId, answer);
            return RedirectToAction("Index");
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}