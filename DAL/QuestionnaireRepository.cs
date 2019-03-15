using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private readonly DemoDbContext ctx;

        public QuestionnaireRepository()
        {
            ctx = new DemoDbContext();
        }

        #region Interface Implementation

        public void CreateUserQuestion(int userId, int questionId, String answer)
        {
            QuestionUser qu = new QuestionUser();
            qu.user = ctx.Users.Find(userId);
            qu.antwoord = answer;
            qu.question = ctx.Questions.Find(questionId);
            ctx.QuestionUsers.Add(qu);
            ctx.SaveChanges();
        }
        
        public IEnumerable<Questionnaire> readQuestionnaires(int id)
        {
            return ctx.Questionnaires
                .Include(q => q.project)
                .Where(q => q.project.id == id);
        }

        public IEnumerable<IotSetup> readIotSetups()
        {
            return ctx.IotSetups.AsEnumerable();
        }

        public IEnumerable<Question> readQuestions(int id)
        {
            return ctx.Questions
                .Include(q => q.questionnaire)
                .Where(q => q.questionnaire.id == id);
        }

        public void createQuestionnaire(Questionnaire q)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.Questionnaires.Add(q);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.SaveChanges();
        }

        public Questionnaire readQuestionnaire(int id)
        {
            return ctx.Questionnaires.Find(id);
        }

        public void updateQuestionnaire(Questionnaire q)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.Questionnaires.Update(q);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void deleteQuestionnaire(int id)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.Questionnaires.Remove(ctx.Questionnaires.Find(id));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.SaveChanges();
        }
        #endregion
    }
}