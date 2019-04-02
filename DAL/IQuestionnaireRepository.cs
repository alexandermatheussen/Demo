using System;
using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IQuestionnaireRepository
    {
        IEnumerable<Questionnaire> readQuestionnaires(int projectId);
        void createQuestionnaire(Questionnaire q);
        Questionnaire readQuestionnaire(int questionnaireId);
        IEnumerable<IotSetup> readIotSetups();
        IEnumerable<Question> readQuestions(int questionnaireId);
        void updateQuestionnaire(Questionnaire q);
        void deleteQuestionnaire(int questionnaireId);
        void createQuestionUser(int userId, int questionId, String answer);
    }
}