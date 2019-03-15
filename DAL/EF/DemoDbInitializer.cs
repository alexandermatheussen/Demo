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
                firstName = "Jan",
                lastName = "Jaap",
                age = 21,
                eMailAddress = "test.persoon@gmail.com",
                gender = Gender.M,
                password = "test",
                postalCode = "2450"
            };
            User u2 = new User(){ firstName = "Peter", lastName = "Smet"};
            User u3 = new User(){ firstName = "Dirk", lastName = "Bakker"};
            #endregion
            
            #region TestProject 1
            Project p1 = new Project()
            {
                confirmedLikes = 0,
                description = "We are thinking about build a new playground in the middle of central park",
                endDate = new DateTime(2019, 3,9),
                startDate = new DateTime(2019,4,10),
                name = "Playground"
            };
            
            // Questionnaires
            Questionnaire questionnaire1 = new Questionnaire()
            {
                name = "Safety",
                questionAmount = 3,
                project = p1,
                confirmed = true,
                iotSetups = new List<IotSetup>(),
                questions = new List<Question>()
            };
            Questionnaire questionnaire2 = new Questionnaire()
            {
                name = "Noise",
                questionAmount = 2,
                project = p1,
                confirmed = false,
                iotSetups = new List<IotSetup>(),
                questions = new List<Question>()
            };
            p1.questionnaires = new List<Questionnaire>() { questionnaire1, questionnaire2 };
            
            // Questions
            Question q1 = new Question()
            {
                question = "Vraag 1",
                questionnaire = questionnaire1,
                questionType = QuestionType.RADIO_BUTTON,
                optionsList = new []{"option1;option2;option3"}
            };
            Question q2 = new Question()
            {
                question = "E-mail address:",
                questionnaire = questionnaire1,
                questionType = QuestionType.MAILADDRESS,
                optionsList = new []{""}
            };
            Question q3 = new Question()
            {
                question = "Vraag 2",
                questionnaire = questionnaire1,
                questionType = QuestionType.DROPDOWN,
                optionsList = new []{"option1;option2;option3"}
            };
            Question q4 = new Question()
            {
                question = "Vraag1",
                questionnaire = questionnaire2,
                questionType = QuestionType.OPEN_QUESTION,
                optionsList = new []{""}
            };
            Question q5 = new Question()
            {
                question = "Vraag 2",
                questionnaire = questionnaire2,
                questionType = QuestionType.OPEN_QUESTION,
                optionsList = new []{""}
            };
            questionnaire1.questions = new List<Question>() { q1, q2, q3 };
            questionnaire2.questions = new List<Question>() { q4, q5 };
            
            // IoTSetups
            IotSetup iot1 = new IotSetup()
            {
                address = new Address(),
                questionnaire = questionnaire1
            };
            questionnaire1.iotSetups = new List<IotSetup>() { iot1 };
            #endregion
            
            #region TestProject 2
            Project p2 = new Project()
            {
                confirmedLikes = 0,
                description = "A project started by the city of antwerp with the intention to adopt street birds",
                endDate = new DateTime(2019, 3,9),
                startDate = new DateTime(2019,4,10),
                phases = new List<Phase>(),
                name = "SAFE THE BIRDS!",
                place = new Place(),
            };
            
            // Questionnaires
            Questionnaire questionnaire3 = new Questionnaire()
            {
                name = "Budget",
                questionAmount = 2,
                project = p2,
                confirmed = true,
                iotSetups = new List<IotSetup>(),
                questions = new List<Question>(),
            };
            p2.questionnaires = new List<Questionnaire>() { questionnaire3 };
            
            // Questions
            Question q6 = new Question()
            {
                question = "Vraag 1",
                questionnaire = questionnaire3,
                questionType = QuestionType.OPEN_QUESTION,
                optionsList = new []{""}
            };
            Question q7 = new Question()
            {
                question = "Vraag 2",
                questionnaire = questionnaire3,
                questionType = QuestionType.RADIO_BUTTON,
                optionsList = new []{"option1;option2;option3"}
            };
            questionnaire3.questions = new List<Question>() { q6, q7 };
            #endregion
            
            QuestionUser qu1 = new QuestionUser()
            {
                question = q1,
                user = u1
            };
            
            //Phases
            Phase ph1 = new Phase() { project = p1, name = "Brainstorming",description = "We are starting this project by gathering input from the community"};
            Phase ph2 = new Phase() { project = p1, name = "Construction",description = "We are building the most suggested constructions in the playground"};
            
            p1.phases = new List<Phase>(){ph1,ph2};

            
            //Ideations 
            
            Ideation it1 = new Ideation(){project = p1};
            
            p1.ideations = new List<Ideation>(){it1};
            
            //IdeationQuestions 

            IdeationQuestion iq1 = new IdeationQuestion(){ideation = it1, question = "What type of constructions do you want on the playground ? "};
            it1.questions = new List<IdeationQuestion>(){iq1};
            
            //Ideas 
            
            Idea i1 = new Idea(){ideation = it1 , user = u1 , title = "Swing" , content = "I think a swing would be a great idea for the playground, it's fun for all ages and it's safe!"};
            Idea i2 = new Idea(){ideation = it1 , user = u2 , title = "Slide" , content = "A slide is very fun! And it doesn't cost much!"};
            
            it1.ideas = new List<Idea>(){ i1,i2};
            
            //answers 
            
            Answer a1 = new Answer(){idea = i1, user = u3,content = " Great Idea !" };
            Answer a2 = new Answer(){idea = i2, user = u3,content = " Terrible Idea !" };
            
            i1.answers = new List<Answer>(){a1};
            i2.answers = new List<Answer>(){a2};
            
            u1.ideas = new List<Idea>(){i1};
            u2.ideas = new List<Idea>(){i2};
            u3.answers = new List<Answer>(){a1,a2};
            
            

            context.questionUsers.Add(qu1);
            context.projects.AddRange(p1, p2);
            context.questionnaires.AddRange(questionnaire1, questionnaire2, questionnaire3);
            context.questions.AddRange(q1, q2, q3, q4, q5, q6, q7);
            context.iotSetups.AddRange(iot1);
            context.phases.AddRange(ph1,ph2);
            context.users.AddRange(u1,u2,u3);
            context.ideations.Add(it1);
            context.ideationQuestions.Add(iq1);
            context.ideas.AddRange(i1,i2);
            context.answers.AddRange(a1,a2);
            
            
            

            context.SaveChanges();
            
            foreach (var entry in context.ChangeTracker.Entries().ToList())
                entry.State = EntityState.Detached;
            
            context.ChangeTracker.QueryTrackingBehavior = previousBehaviour;
        }
    }
}