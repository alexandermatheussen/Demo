using System;
using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IQuestionnaireRepository
    {
        IEnumerable<Questionnaire> readQuestionnaires(int id);
        void createQuestionnaire(Questionnaire q);
        void CreateUserQuestion(int userId, int questionId, String answer);
        Questionnaire readQuestionnaire(int id);
        IEnumerable<IotSetup> readIotSetups();
        IEnumerable<Question> readQuestions(int id);
        void updateQuestionnaire(Questionnaire q);
        void deleteQuestionnaire(int id);
    }
}