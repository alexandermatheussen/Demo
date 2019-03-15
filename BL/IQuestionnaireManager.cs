using System;
using System.Collections.Generic;
using Domain;

namespace BL
{
    public interface IQuestionnaireManager
    {
        IEnumerable<Questionnaire> getQuestionnaires(int id);
        IEnumerable<IotSetup> getIotSetups();
        IEnumerable<Question> getQuestions(int id);
        Questionnaire getQuestionnaire(int id);
        void addQuestionnaire(int id, List<Question> questions, List<IotSetup> iotSetups, 
            int questionAmount, Boolean confirmed, Project project);
        void addQuestionnaire(Questionnaire q);
        void changeQuestionnaire(Questionnaire q);
        void removeQuestionnaire(int id);
        void addQuestionUser(int userId, int questionId, String answer);
    }
}