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

        public QuestionnaireRepository(UnitOfWork unitOfWork)
        {
            if(unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");
            ctx = unitOfWork.Context;
        }

        #region Interface Implementation

        public void createQuestionUser(int userId, int questionId, String answer)
        {
            QuestionUser qu = new QuestionUser();
            qu.User = ctx.users.Find(userId);
            qu.Question = ctx.questions.Find(questionId);
            qu.Answer = answer;
            ctx.questionUsers.Add(qu);
            ctx.SaveChanges();
        }
        public IEnumerable<Questionnaire> readQuestionnaires(int id)
        {
            return ctx.questionnaires
                .Include(q => q.project)
                .Where(q => q.project.projectId == id);
        }

        public IEnumerable<IotSetup> readIotSetups()
        {
            return ctx.iotSetups.AsEnumerable();
        }

        public IEnumerable<Question> readQuestions(int id)
        {
            return ctx.questions
                .Include(q => q.questionnaire)
                .Include(q => q.options)
                .Where(q => q.questionnaire.id == id);
        }

        public void createQuestionnaire(Questionnaire q)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.questionnaires.Add(q);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.SaveChanges();
        }

        public Questionnaire readQuestionnaire(int id)
        {
            return ctx.questionnaires.Find(id);
        }

        public void updateQuestionnaire(Questionnaire q)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.questionnaires.Update(q);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void deleteQuestionnaire(int id)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.questionnaires.Remove(ctx.questionnaires.Find(id));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (QuestionnaireRepo.Ctx)");
            ctx.SaveChanges();
        }
        #endregion
    }
}