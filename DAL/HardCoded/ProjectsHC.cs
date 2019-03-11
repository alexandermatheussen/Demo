using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using Domain;

namespace DAL.HardCoded
{
    public class ProjectsHC
    {
        public static void CreateProjects()
        {
           DAL.EF.DemoContext ctx = new DemoContext();

           Project p1 = new Project()
           {
               confirmedLikes = 0,
               description = "A project started by the city of antwerp with the intention to adopt street dogs",
               endDate = new DateTime(2019, 3,9),
               startDate = new DateTime(2019,4,10),
               fases = new List<Fase>(),
               ideations = new List<Ideation>(),
               name = "SAFE THE DOGS!",
               place = new Place(),
               questionnaires = new List<Questionnaire>()
           };
           /*Project p2 = new Project("SAFE THE BIRDS!",
               "A project started by the city of antwerp with the intention to adopt street birds");
           Project p3 = new Project("SAFE THE CATS!",
               "A project started by the city of antwerp with the intention to adopt street cats");*/
           
           Questionnaire questionnaire1 = new Questionnaire()
           {
               questionAmount = 2,
               confirmed = true,
               iotSetups = new List<IotSetup>(),
               questions = new List<Question>(),
               project = p1
           };
           p1.questionnaires.Add(questionnaire1);
           
           Question question1 = new Question()
           {
                question = "Vraag 1",
                questionnaire = questionnaire1,
                questionType = QuestionType.RADIO_BUTTON
           };
           questionnaire1.questions.Add(question1);
           
           Question question2 = new Question()
           {
               question = "E-mail address:",
               questionnaire = questionnaire1,
               questionType = QuestionType.MAILADDRESS
           };
           questionnaire1.questions.Add(question2);

           ctx.Questions.Add(question1);
           ctx.Questions.Add(question2);
           ctx.Questionnaires.Add(questionnaire1);
           ctx.Projects.Add(p1);
           //ctx.Projects.Add(p2);
           //ctx.Projects.Add(p3);
           ctx.SaveChanges();
        }
    }
}