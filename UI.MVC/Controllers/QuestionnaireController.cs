using System;
using System.Collections.Generic;
using BL;
using D.UI.MVC.Models;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace D.UI.MVC.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IQuestionnaireManager qmgr;

        public QuestionnaireController()
        {
            qmgr = new QuestionnaireManager();
        }
        
        public IActionResult Questionnaires(int projectId)
        {
            IEnumerable<Questionnaire> allQuestionnaires = qmgr.getQuestionnaires(projectId);
            return View(allQuestionnaires);
        }
        
        public IActionResult Questionnaire(int questionnaireId)
        {
            CombinedModel combinedModel = new CombinedModel();
            combinedModel.questions = qmgr.getQuestions(questionnaireId);
            return View(combinedModel);
        }

        [HttpPost]
        public IActionResult CreateUserQuestion(int userId, IFormCollection form)
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
                        qmgr.addQuestionUser(userId, currentQuestionIds[currentQuestion], answer);
                        currentQuestion++;
                    }
                }
                if (key.StartsWith("CheckBox"))
                {
                    qmgr.addQuestionUser(userId, currentQuestionIds[currentQuestion], form[key]);
                    currentQuestion++;
                }
            }
            return RedirectToAction("Projects", "Project");
        }
    }
}