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
        
        public void addQuestionnaire(List<Question> questions, String name, int questionAmount, bool confirmed, int projectId)
        {
            Questionnaire newQuestionnaire = new Questionnaire();
            newQuestionnaire.questions = questions;
            newQuestionnaire.name = name;
            newQuestionnaire.questionAmount = questionAmount;
            newQuestionnaire.confirmed = confirmed;
            repo.createQuestionnaire(newQuestionnaire, projectId);
        }

        public void addQuestionUser(int userId, int questionId, String answer)
        {
            repo.createQuestionUser(userId, questionId, answer);
        }

        public void addQuestion(String question, QuestionType questionType)
        {
            Question newQuestion = new Question();
            newQuestion.question = question;
            newQuestion.questionType = questionType;
            repo.createQuestion(newQuestion);
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