﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            return View(qmgr.getQuestions(id));
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}