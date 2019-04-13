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
        IEnumerable<Option> getOptions(int questionId);
        Questionnaire getQuestionnaire(int id);
        Question getQuestion(int id);
        void addQuestionnaire(List<Question> questions, String name,
            int questionAmount, Boolean confirmed, int projectId);
        void addQuestion(String question, QuestionType questionType);
        void addQuestion(Question question);
        void addOption(String option, Question question);
        void changeQuestionnaire(Questionnaire q);
        void removeQuestionnaire(int id);
        void addQuestionUser(int userId, int questionId, String answer);
        void changeQuestion(Question q);
        void removeQuestion(int id);
        void changeOption(Option o);
        void removeOption(int optionId);
    }
}