using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IProjectManager pmgr;

        public QuestionnaireController()
        {
            qmgr = new QuestionnaireManager();
            pmgr = new ProjectManager();
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

        public IActionResult CreateQuestionnairePage(int projectId)
        {
            QuestionnaireQuestion combinedModel = new QuestionnaireQuestion();
            combinedModel.projectId = projectId;
            return View(combinedModel);
        }
        
        [HttpPost]
        public IActionResult CreateQuestionnaire(IFormCollection form)
        {
            int projectId = 0;
            String questionnaireName = null;
            Boolean questionnaireConfirmed = true;
            List<Question> questions = new List<Question>();
            var currentFieldset = 1;
            IList<String> fieldTypes = new List<String>();
            var currentField = 0;
            IList<Option> options = new List<Option>();
            IList<int> currentQuestion = new List<int>();
            currentQuestion.Add(0);
            var currentOption = 1;
            
            foreach (var fieldset in form.Keys)
            {
                var ending = "dynamicFieldset" + currentFieldset;
                if (fieldset == ending)
                {
                    if (form[fieldset] == "email") { fieldTypes.Add("email"); currentFieldset++; }
                    if (form[fieldset] == "dropdown") { fieldTypes.Add("dropdown"); currentFieldset++; }
                    if (form[fieldset] == "radiobutton") { fieldTypes.Add("radiobutton"); currentFieldset++; }
                    if (form[fieldset] == "checkbox") { fieldTypes.Add("checkbox"); currentFieldset++; }
                    if (form[fieldset] == "textarea") { fieldTypes.Add("textarea"); currentFieldset++; }
                }
                if (fieldset.StartsWith("question.options"))
                {
                    var parts = fieldset.Split("-");
                    currentQuestion.Add(Convert.ToInt32(parts[2]));
                    Option o = new Option()
                    {
                        option = form[fieldset]
                    };
                    options.Add(o);
                }
            }
            foreach (var key in form.Keys)
            {
                if (key == "projectId")
                {
                    foreach (var id in form[key])
                    {
                        projectId = Convert.ToInt32(id);
                    }
                }
                if (key == "questionnaire.name")
                {
                    foreach (var name in form[key])
                    {
                        questionnaireName = name;
                    }
                }
                if (key == "confirmed")
                {
                    foreach (var confirmed in form[key])
                    {
                        if (confirmed == "Yes")
                        {
                            questionnaireConfirmed = true;
                        } 
                        else if (confirmed == "No")
                        {
                            questionnaireConfirmed = false;
                        }
                    }
                }
                if (key == "question.question")
                {
                    foreach (var question in form[key])
                    {
                        Question q = new Question()
                        {
                            question = question,
                            questionnaire = null,
                            questionType = QuestionType.OPEN_QUESTION,
                            IotSetup = null,
                            options = new List<Option>()
                        };
                        IList<Option> finalOptions = new List<Option>();
                        if (fieldTypes[currentField] == "email") { q.questionType = QuestionType.MAILADDRESS; }
                        if (fieldTypes[currentField] == "dropdown") { q.questionType = QuestionType.DROPDOWN; }
                        if (fieldTypes[currentField] == "radiobutton") { q.questionType = QuestionType.RADIO_BUTTON; }
                        if (fieldTypes[currentField] == "checkbox") { q.questionType = QuestionType.CHECK_BOX; }
                        if (fieldTypes[currentField] == "textarea") { q.questionType = QuestionType.OPEN_QUESTION; }
                        currentField++;
                        for (var i = 1; i < options.Count+1; i++)
                        {
                            if (currentQuestion[i] == currentOption)
                            {
                                Console.WriteLine("ja" + options[i-1].option + " fieldset: " + currentOption);
                                finalOptions.Add(options[i-1]);
                            }
                        }
                        q.options = finalOptions;
                        questions.Add(q);
                        currentOption++;
                    }
                }
            }
            qmgr.addQuestionnaire(questions, questionnaireName, questions.Count, questionnaireConfirmed, projectId);
            return RedirectToAction("Projects","Project");
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