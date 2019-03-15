using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BL.Managers;
using DAL;
using Domain;

namespace BL
{
    public class QuestionnaireManager : IQuestionnaireManager
    {
        private IQuestionnaireRepository repo;

        public QuestionnaireManager()
        {
            repo = new QuestionnaireRepository();
        }

        public QuestionnaireManager(UnitOfWorkManager unitOfWorkManager)
        {
            if (unitOfWorkManager == null)
            {
                throw new ArgumentException("unitOfWorkManager");
            }
            repo = new QuestionnaireRepository(unitOfWorkManager.UnitOfWork);
        }

        public IEnumerable<Questionnaire> getQuestionnaires(int id)
        {
            return repo.readQuestionnaires(id);
        }

        public IEnumerable<IotSetup> getIotSetups()
        {
            return repo.readIotSetups();
        }

        public IEnumerable<Question> getQuestions(int id)
        {
            return repo.readQuestions(id);
        }

        public Questionnaire getQuestionnaire(int id)
        {
            return repo.readQuestionnaire(id);
        }
        
        public void addQuestionnaire(int id, List<Question> questions, List<IotSetup> iotSetups, int questionAmount, bool confirmed,
            Project project)
        {
            Questionnaire newQuestionnaire = new Questionnaire();
            newQuestionnaire.project = project;
            newQuestionnaire.confirmed = confirmed;
            newQuestionnaire.questions = questions;
            newQuestionnaire.iotSetups = iotSetups;
            newQuestionnaire.questionAmount = questionAmount;
            repo.createQuestionnaire(newQuestionnaire);
        }

        public void addQuestionUser(int userId, int questionId, String answer)
        {
            repo.createQuestionUser(userId, questionId, answer);
        }

        public void addQuestionnaire(Questionnaire q)
        {
            repo.createQuestionnaire(q);
        }

        public void changeQuestionnaire(Questionnaire q)
        {
            Validator.ValidateObject(q, new ValidationContext(q));
            repo.updateQuestionnaire(q);
        }

        public void removeQuestionnaire(int id)
        {
            repo.deleteQuestionnaire(id);
        }
    }
}