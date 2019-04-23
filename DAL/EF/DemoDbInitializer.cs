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
                description = "We are thinking about building a new playground in the middle of central park",
                endDate = new DateTime(2019, 3,9),
                startDate = new DateTime(2019,4,10),
                name = "Playground"
            };
            
            // Questionnaires
            Questionnaire questionnaire1 = new Questionnaire()
            {
                name = "Safety",
                questionAmount = 4,
                project = p1,
                questions = new List<Question>()
            };
            Questionnaire questionnaire2 = new Questionnaire()
            {
                name = "Noise",
                questionAmount = 3,
                project = p1,
                questions = new List<Question>()
            };
            p1.questionnaires = new List<Questionnaire>() { questionnaire1, questionnaire2 };
            
            // Questions
            Question q1 = new Question()
            {
                question = "Do we need to build a fence around the playground?",
                questionnaire = questionnaire1,
                questionType = QuestionType.RADIO_BUTTON,
                IotSetup = null,
                options = new List<Option>()
            };
            Option o1 = new Option() {option = "Yes", question = q1};
            Option o2 = new Option() {option = "No", question = q1};
            q1.options = new List<Option>() { o1, o2 };
            Question question1 = new Question()
            {
                question = "How big should the playground be?",
                questionnaire = questionnaire1,
                questionType = QuestionType.RADIO_BUTTON,
                IotSetup = null,
                options = new List<Option>()
            };
            Option option1 = new Option() {option = "50m²", question = question1};
            Option option2 = new Option() {option = "60m²", question = question1};
            Option option3 = new Option() {option = "80m²", question = question1};
            Option option4 = new Option() {option = "100m²", question = question1};
            question1.options = new List<Option>() { option1, option2, option3, option4 };
            Question q2 = new Question()
            {
                question = "Where should we build the playground",
                questionnaire = questionnaire1,
                questionType = QuestionType.DROPDOWN,
                IotSetup = null,
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
                IotSetup = null,
                options = new List<Option>()
            };
            Question q4 = new Question()
            {
                question = "What should we do about the noise polution of the playground?",
                questionnaire = questionnaire2,
                questionType = QuestionType.OPEN_QUESTION,
                IotSetup = new IotSetup(),
                options = new List<Option>()
            };
            Question q5 = new Question()
            {
                question = "Do you think a playground would be anoying if it was near your home?",
                questionnaire = questionnaire2,
                questionType = QuestionType.OPEN_QUESTION,
                IotSetup = null,
                options = new List<Option>()
            };
            Question question2 = new Question()
            {
                question = "What should we add to the playground?",
                questionnaire = questionnaire2,
                questionType = QuestionType.CHECK_BOX,
                IotSetup = null,
                options = new List<Option>()
            };
            Option option5 = new Option() {option = "Slide", question = question2};
            Option option6 = new Option() {option = "Drinking fountain", question = question2};
            Option option7 = new Option() {option = "Swing", question = question2};
            question2.options = new List<Option>() { option5, option6, option7 };
            // IoTSetups
            IotSetup iot1 = new IotSetup()
            {
                address = new Address(),
            };
            q4.IotSetup = iot1;
            
            questionnaire1.questions = new List<Question>() { q1, q2, q3, question1 };
            questionnaire2.questions = new List<Question>() { q4, q5, question2 };
            #endregion
            
            #region TestProject 2
            Project p2 = new Project()
            {
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
                questionAmount = 4,
                project = p2,
                questions = new List<Question>(),
            };
            p2.questionnaires = new List<Questionnaire>() { questionnaire3 };
            
            // Questions
            Question q6 = new Question()
            {
                question = "What should we do to save the birds?",
                questionnaire = questionnaire3,
                questionType = QuestionType.OPEN_QUESTION,
                IotSetup = null,
                options = new List<Option>()
            };
            Question q7 = new Question()
            {
                question = "What do you think should be our first priority?",
                questionnaire = questionnaire3,
                questionType = QuestionType.RADIO_BUTTON,
                IotSetup = null,
                options = new List<Option>()
            };
            Option o6 = new Option() {option = "Build birds more houses", question = q7};
            Option o7 = new Option() {option = "Give more options for birds to eat", question = q7};
            Option o8 = new Option() {option = "Give more options for birds to drink", question = q7};
            Option o9 = new Option() {option = "Plant more trees", question = q7};
            q7.options = new List<Option>() { o6, o7, o8, o9 };
            Question q8 = new Question()
            {
                question = "What should we feed the birds?",
                questionnaire = questionnaire3,
                questionType = QuestionType.CHECK_BOX,
                IotSetup = null,
                options = new List<Option>()
            };
            Option o10 = new Option() {option = "Grains", question = q8};
            Option o11 = new Option() {option = "Seeds", question = q8};
            Option o12 = new Option() {option = "Chocolat", question = q8};
            q8.options = new List<Option>() { o10, o11, o12 };
            Question q9 = new Question()
            {
                question = "How should we feed the birds",
                questionnaire = questionnaire3,
                questionType = QuestionType.CHECK_BOX,
                IotSetup = null,
                options = new List<Option>()
            };
            Option o13 = new Option() {option = "With bowls", question = q9};
            Option o14 = new Option() {option = "On the floor", question = q9};
            Option o15 = new Option() {option = "Hanging in the tree", question = q9};
            q9.options = new List<Option>() { o13, o14, o15 };
            questionnaire3.questions = new List<Question>() { q6, q7, q8, q9 };
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
            
           
         //   fields.Add(if1);
            //Ideas 
            
            Idea i1 = new Idea(){ideation = it1 , user = u1 };
            Idea i2 = new Idea(){ideation = it1 , user = u2 };

           // it1.fields = null;
            
            it1.ideas = new List<Idea>(){ i1,i2};
            //Fields
            ICollection<Field> fields = new List<Field>();
            ImageField if1 = new ImageField(){imageName = "testimage",idea = i1};
            i1.fields = new List<Field>(){if1};
           
           
            //answers 
           // Reaction a3 = new Reaction(){content = "test",idea = null};
            
            Reaction a1 = new Reaction(){idea = i1, user = u3,content = " Great Idea !" };
            Reaction a2 = new Reaction(){idea = i2, user = u3,content = " Terrible Idea !" };
            
            i1.reactions = new List<Reaction>(){a1};
            i2.reactions = new List<Reaction>(){a2};
            
            u1.ideas = new List<Idea>(){i1};
            u2.ideas = new List<Idea>(){i2};
            u3.reactions = new List<Reaction>(){a1,a2};

            context.projects.AddRange(p1, p2);
            context.questionnaires.AddRange(questionnaire1, questionnaire2, questionnaire3);
            context.questions.AddRange(q1, question1, q2, q3, q4, q5, question2, q6, q7, q8, q9);
            context.iotSetups.AddRange(iot1);
            context.phases.AddRange(ph1,ph2);
            context.users.AddRange(u1,u2,u3);
            context.ideations.Add(it1);
            context.ideationQuestions.Add(iq1);
            context.ideas.AddRange(i1,i2);
            context.fields.Add(if1);

            context.answers.AddRange(a1,a2);
            context.options.AddRange(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13, o14, o15, option1, option2, option3, option4, option5, option6, option7);
            
            context.SaveChanges();
            
            foreach (var entry in context.ChangeTracker.Entries().ToList())
                entry.State = EntityState.Detached;
            
            context.ChangeTracker.QueryTrackingBehavior = previousBehaviour;
        }
    }
}