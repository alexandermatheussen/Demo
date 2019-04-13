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

        public IActionResult EditQuestionnairePage(int questionnaireId)
        {
            QuestionnaireQuestion combinedModel = new QuestionnaireQuestion();
            combinedModel.questionnaire = qmgr.getQuestionnaire(questionnaireId);
            combinedModel.questions = qmgr.getQuestions(questionnaireId);
            return View(combinedModel);
        }

        public IActionResult DeleteQuestionnairePage(int questionnaireId)
        {
            Questionnaire questionnaire = qmgr.getQuestionnaire(questionnaireId);
            return View(questionnaire);
        }

        [HttpPost]
        public IActionResult EditQuestionnaire(IFormCollection form)
        {
            var oldQuestionnaireId = 0;
            var oldQuestionnaireName = "";
            var oldQuestionnaireConfirmed = true;
            ICollection<String> questionOptionKey = new List<string>();
            ICollection<String> questionOptionValue = new List<string>();
            
            foreach (var key in form.Keys)
            {
                if (key == "questionnaire.id")
                {
                    oldQuestionnaireId = Convert.ToInt32(form[key]);
                }
            }
            
            ICollection<int> notRemovedQuestionIds = new List<int>();
            Questionnaire oldQuestionnaire = qmgr.getQuestionnaire(oldQuestionnaireId);
            ICollection<Question> oldQuestions = qmgr.getQuestions(oldQuestionnaireId).ToList();

            foreach (var key in form.Keys)
            {
                if (key.StartsWith("question.question"))
                {
                    Question q = new Question()                    
                    {                                              
                        question = "",                      
                        questionnaire = oldQuestionnaire,          
                        questionType = QuestionType.OPEN_QUESTION, 
                        IotSetup = null,                           
                        options = new List<Option>()               
                    };
                    IList<Option> newOptions = new List<Option>();
                    string[] parts = key.Split("-");
                    int optionAmount = 1;
                    foreach (var subKey in form.Keys)
                    {
                        if (subKey == "dynamicFieldset" + parts[1])                                             
                        {        
                            if (form[subKey] == "email") { q.questionType = QuestionType.MAILADDRESS; }       
                            if (form[subKey] == "dropdown") { q.questionType = QuestionType.DROPDOWN; }         
                            if (form[subKey] == "radiobutton") { q.questionType = QuestionType.RADIO_BUTTON; }  
                            if (form[subKey] == "checkbox") { q.questionType = QuestionType.CHECK_BOX; }        
                            if (form[subKey] == "textarea") { q.questionType = QuestionType.OPEN_QUESTION; } 
                        }
                        if (subKey == "question.options-" + optionAmount + "-" + parts[1] + "-0")
                        {
                            Option o = new Option()
                            {
                                option = form[subKey],
                                question = q
                            };
                            newOptions.Add(o);
                            optionAmount++;
                        }
                    }
                    q.question = form[key];
                    qmgr.addQuestion(q);                           
                    qmgr.changeQuestionnaire(oldQuestionnaire);    
                    foreach (var o in newOptions)
                    {
                        qmgr.addOption(o.option, o.question);
                    }
                    q.options = newOptions;
                    qmgr.changeQuestion(q);
                }    
                if (key.StartsWith("question.options-"))         
                {
                    questionOptionKey.Add(key);                  
                    questionOptionValue.Add(form[key]);          
                }
            }
            foreach (var key in form.Keys)
            {
                if (key == "questionnaire.name")
                {
                    oldQuestionnaireName = form[key];
                }
                if (key == "confirmed")
                {
                    if (form[key] == "No")
                    {
                        oldQuestionnaireConfirmed = false;
                    }
                }
                if (key.StartsWith("question-"))
                {
                    string[] parts = key.Split("-");
                    notRemovedQuestionIds.Add(Convert.ToInt32(parts[1]));
                    int testt = 1;
                    for (var i = 0; i < oldQuestions.Count; i++)
                    {
                        if (Convert.ToInt32(parts[1]) == oldQuestions.ToList()[i].id)
                        {
                            Question q = oldQuestions.ToList()[i];
                            q.question = form[key];
                            qmgr.changeQuestion(q);

                            ICollection<Option> options = qmgr.getOptions(q.id).ToList();

                            foreach (var o in options)
                            {
                                qmgr.removeOption(o.id);
                            }

                            for (var a = 0; a < questionOptionKey.Count(); a++)
                            {
                                string[] partsKey = questionOptionKey.ToList()[a].Split("-");
                                if (Convert.ToInt32(partsKey[3]) == q.id)
                                {
                                    Option o = new Option()
                                    {
                                        option = questionOptionValue.ToList()[a],
                                        question = q
                                    };
                                    q.options.ToList().Add(o);
                                    qmgr.changeQuestion(q);
                                    qmgr.addOption(o.option, o.question);
                                }
                                if (Convert.ToInt32(partsKey[2]) == testt && Convert.ToInt32(partsKey[3]) == 0)
                                {
                                    Option o = new Option()
                                    {
                                        option = questionOptionValue.ToList()[a],
                                        question = q
                                    };
                                    q.options.ToList().Add(o);
                                    qmgr.addOption(o.option, q);
                                    qmgr.changeQuestion(q);
                                }
                            }
                        }
                        testt++;
                    }
                }
                if (key.StartsWith("dynamicFieldset"))
                {
                    string[] parts = key.Split("t");
                    for (var i = 0; i < oldQuestions.Count; i++)
                    {
                        if (Convert.ToInt32(parts[1]) == i+1)
                        {
                            Question q = oldQuestions.ToList()[i];
                            if (form[key] == "email") { q.questionType = QuestionType.MAILADDRESS; }
                            if (form[key] == "dropdown") { q.questionType = QuestionType.DROPDOWN; }
                            if (form[key] == "radiobutton") { q.questionType = QuestionType.RADIO_BUTTON; }
                            if (form[key] == "checkbox") { q.questionType = QuestionType.CHECK_BOX; }
                            if (form[key] == "textarea") { q.questionType = QuestionType.OPEN_QUESTION; }
                            qmgr.changeQuestion(q);
                        }
                    }
                }
            }
            oldQuestionnaire.name = oldQuestionnaireName;
            oldQuestionnaire.confirmed = oldQuestionnaireConfirmed;
            oldQuestionnaire.questionAmount = oldQuestions.Count;
            qmgr.changeQuestionnaire(oldQuestionnaire);
            foreach (var q in oldQuestions)
            {
                var removeThis = true;
                foreach (var id in notRemovedQuestionIds)
                {
                    if (q.id == id)
                    {
                        removeThis = false;
                    }
                }
                if (removeThis)
                {
                    IList<Option> remOptions = qmgr.getOptions(q.id).ToList();
                    foreach (var o in remOptions)
                    {
                        qmgr.removeOption(o.id);
                    }
                    qmgr.removeQuestion(q.id);
                }
            }
            oldQuestionnaire.questionAmount = qmgr.getQuestions(oldQuestionnaire.id).Count();
            qmgr.changeQuestionnaire(oldQuestionnaire);
            return RedirectToAction("Projects","Project");
        }

        [HttpPost]
        public IActionResult DeleteQuestionnaire(IFormCollection form)
        {
            foreach (var key in form.Keys)
            {
                if (key == "id")
                {
                    int questionnaireId = Convert.ToInt32(form[key]);
                    IList<Question> questions = qmgr.getQuestions(questionnaireId).ToList();
                    foreach (var q in questions)
                    {
                        IList<Option> options = qmgr.getOptions(q.id).ToList();
                        foreach (var o in options)
                        {
                            qmgr.removeOption(o.id);
                        }
                        qmgr.removeQuestion(q.id);
                    }
                    qmgr.removeQuestionnaire(questionnaireId);
                }
            }
            return RedirectToAction("Projects","Project");
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