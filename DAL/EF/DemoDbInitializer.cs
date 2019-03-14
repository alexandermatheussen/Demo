using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class DemoDbInitializer
    {
        private static bool hasRunDuringApplicationExecution;

        public static void Initialize(DemoDbContext context, bool forceDropCreateDatabase = false)
        {
            if (!hasRunDuringApplicationExecution)
            {
                if (forceDropCreateDatabase)
                    context.Database.EnsureDeleted();

                if (context.Database.EnsureCreated())
                    Seed(context);

                hasRunDuringApplicationExecution = true;
            }
        }

        private static void Seed(DemoDbContext context)
        {
            var previousBehaviour = context.ChangeTracker.QueryTrackingBehavior;
            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            
            #region User
            User u1 = new User()
            {
                firstName = "Test",
                lastName = "Persoon",
                age = 21,
                answers = new List<Answer>(),
                eMailAddress = "test.persoon@gmail.com",
                gender = Gender.M,
                ideas = new List<Idea>(),
                password = "test",
                postalCode = "2450"
            };
            
            #endregion
            
            #region TestProject 1
            Project p1 = new Project()
            {
                confirmedLikes = 0,
                description = "A project started by the city of antwerp with the intention to adopt street dogs",
                endDate = new DateTime(2019, 3,9),
                startDate = new DateTime(2019,4,10),
                fases = new List<Fase>(),
                name = "SAFE THE DOGS!",
                place = new Place(),
            };
            
            // Questionnaires
            Questionnaire questionnaire1 = new Questionnaire()
            {
                questionAmount = 3,
                project = p1,
                confirmed = true,
                iotSetups = new List<IotSetup>(),
                questions = new List<Question>(),
                user = null
            };
            Questionnaire questionnaire2 = new Questionnaire()
            {
                questionAmount = 2,
                project = p1,
                confirmed = false,
                iotSetups = new List<IotSetup>(),
                questions = new List<Question>(),
                user = null
            };
            p1.questionnaires = new List<Questionnaire>() { questionnaire1, questionnaire2 };
            
            // Questions
            Question q1 = new Question()
            {
                question = "Vraag 1",
                questionnaire = questionnaire1,
                questionType = QuestionType.RADIO_BUTTON
            };
            Question q2 = new Question()
            {
                question = "E-mail address:",
                questionnaire = questionnaire1,
                questionType = QuestionType.MAILADDRESS
            };
            Question q3 = new Question()
            {
                question = "Vraag 2",
                questionnaire = questionnaire1,
                questionType = QuestionType.DROPDOWN
            };
            Question q4 = new Question()
            {
                question = "Vraag1",
                questionnaire = questionnaire2,
                questionType = QuestionType.OPEN_QUESTION
            };
            Question q5 = new Question()
            {
                question = "Vraag 2",
                questionnaire = questionnaire2,
                questionType = QuestionType.OPEN_QUESTION
            };
            questionnaire1.questions = new List<Question>() { q1, q2, q3 };
            questionnaire2.questions = new List<Question>() { q4, q5 };
            
            // IoTSetups
            IotSetup i1 = new IotSetup()
            {
                address = new Address(),
                questionnaire = questionnaire1
            };
            questionnaire1.iotSetups = new List<IotSetup>() { i1 };
            #endregion
            
            #region TestProject 2
            Project p2 = new Project()
            {
                confirmedLikes = 0,
                description = "A project started by the city of antwerp with the intention to adopt street birds",
                endDate = new DateTime(2019, 3,9),
                startDate = new DateTime(2019,4,10),
                fases = new List<Fase>(),
                name = "SAFE THE BIRDS!",
                place = new Place(),
            };
            
            // Questionnaires
            Questionnaire questionnaire3 = new Questionnaire()
            {
                questionAmount = 2,
                project = p2,
                confirmed = true,
                iotSetups = new List<IotSetup>(),
                questions = new List<Question>(),
                user = null
            };
            p2.questionnaires = new List<Questionnaire>() { questionnaire3 };
            
            // Questions
            Question q6 = new Question()
            {
                question = "Vraag 1",
                questionnaire = questionnaire3,
                questionType = QuestionType.OPEN_QUESTION
            };
            Question q7 = new Question()
            {
                question = "Vraag 2",
                questionnaire = questionnaire3,
                questionType = QuestionType.RADIO_BUTTON
            };
            questionnaire3.questions = new List<Question>() { q6, q7 };
            #endregion
            
            context.Projects.AddRange(p1, p2);
            context.Questionnaires.AddRange(questionnaire1, questionnaire2, questionnaire3);
            context.Questions.AddRange(q1, q2, q3, q4, q5, q6, q7);
            context.IotSetups.AddRange(i1);

            context.SaveChanges();
            
            foreach (var entry in context.ChangeTracker.Entries().ToList())
                entry.State = EntityState.Detached;
            
            context.ChangeTracker.QueryTrackingBehavior = previousBehaviour;
        }
    }
}