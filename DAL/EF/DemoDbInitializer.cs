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
                postalCode = "2450",
                questionnaireAnswer = new List<QuestionUser>()
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
                question = "Do we need to build a fence around the playground?",
                questionnaire = questionnaire1,
                questionType = QuestionType.RADIO_BUTTON,
                options = new List<Option>()
            };
            Option o1 = new Option() {option = "Yes", question = q1};
            Option o2 = new Option() {option = "No", question = q1};
            q1.options = new List<Option>() { o1, o2 };
            Question q2 = new Question()
            {
                question = "Where should we build the playground",
                questionnaire = questionnaire1,
                questionType = QuestionType.DROPDOWN,
                options = new List<Option>()
            };
            Option o3 = new Option() {option = "Brooklyn Street", question = q2};
            Option o4 = new Option() {option = "Second street", question = q2};
            Option o5 = new Option() {option = "New road", question = q2};
            q2.options = new List<Option>() { o3, o4, o5 };
            Question q3 = new Question()
            {
                question = "Fill in your e-mail address:",
                questionnaire = questionnaire1,
                questionType = QuestionType.MAILADDRESS,
                options = new List<Option>()
            };
            Question q4 = new Question()
            {
                question = "What should we do about the noise polution of the playground?",
                questionnaire = questionnaire2,
                questionType = QuestionType.OPEN_QUESTION,
                options = new List<Option>()
            };
            Question q5 = new Question()
            {
                question = "Do you think a playground would be anoying if it was near your home?",
                questionnaire = questionnaire2,
                questionType = QuestionType.OPEN_QUESTION,
                options = new List<Option>()
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
                question = "What should we do to save the birds?",
                questionnaire = questionnaire3,
                questionType = QuestionType.OPEN_QUESTION,
                options = new List<Option>()
            };
            Question q7 = new Question()
            {
                question = "What do you think should be our first priority?",
                questionnaire = questionnaire3,
                questionType = QuestionType.RADIO_BUTTON,
                options = new List<Option>()
            };
            Option o6 = new Option() {option = "Build birds more houses", question = q7};
            Option o7 = new Option() {option = "Give more options for birds to eat", question = q7};
            Option o8 = new Option() {option = "Give more options for birds to drink", question = q7};
            Option o9 = new Option() {option = "Plant more trees", question = q7};
            q7.options = new List<Option>() { o6, o7, o8, o9 };
            questionnaire3.questions = new List<Question>() { q6, q7 };
            #endregion
            
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

            QuestionUser qu = new QuestionUser() { Question = q1, User = u1, Answer = "Yes"};
            u1.questionnaireAnswer = new List<QuestionUser>() {qu};
            q1.questionnaireAnswers = new List<QuestionUser>(){qu};

            context.questionUsers.Add(qu);
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
            context.options.AddRange(o1, o2, o3, o4, o5, o6, o7, o8, o9);
            

            context.SaveChanges();
            
            foreach (var entry in context.ChangeTracker.Entries().ToList())
                entry.State = EntityState.Detached;
            
            context.ChangeTracker.QueryTrackingBehavior = previousBehaviour;
        }
    }
}