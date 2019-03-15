using System;
using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IQuestionnaireRepository
    {
        IEnumerable<Questionnaire> readQuestionnaires(int id);
        void createQuestionnaire(Questionnaire q);
        Questionnaire readQuestionnaire(int id);
        IEnumerable<IotSetup> readIotSetups();
        IEnumerable<Question> readQuestions(int id);
        void updateQuestionnaire(Questionnaire q);
        void deleteQuestionnaire(int id);
        void createQuestionUser(int userId, int questionId, String answer);
    }
}