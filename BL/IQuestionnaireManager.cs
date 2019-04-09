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
        void addQuestionnaire(List<Question> questions, String name,
            int questionAmount, Boolean confirmed, int projectId);
        void addQuestion(String question, QuestionType questionType);
        void changeQuestionnaire(Questionnaire q);
        void removeQuestionnaire(int id);
        void addQuestionUser(int userId, int questionId, String answer);
    }
}