using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IIdeationRepository
    {
        #region Ideations

        IEnumerable<Ideation> readIdeations(int projectId);
        void createIdeation(Ideation i);
        Ideation readIdeation(int id);
        void updateIdeation(Ideation i);
        void deleteIdeation(int id);

        

         #endregion

         #region IdeationQuestions
         IEnumerable<IdeationQuestion> readIdeationsQuestionsForProject(int projectId);
         
         IEnumerable<IdeationQuestion> readIdeationsQuestions(int ideationId);

         
         void createIdeationQuestion(IdeationQuestion i);
         IdeationQuestion readIdeationQuestion(int id);
         void updateIdeationQuestion(IdeationQuestion i);
         void deleteIdeationQuestion(int id);
         

         #endregion

         #region Ideas
         IEnumerable<Idea> readIdeas(int ideationId);
         void createIdea(Idea i);
         Idea readIdea(int ideaId);
         void updateIdea(Idea i);
         void deleteIdea(int ideaId);

         

         #endregion

         #region Answers
         IEnumerable<Answer> readAnswers(int ideaId);
         void createAnswer(Answer a);
         Ideation readAnswer(int answerId);
         void updateAnswer(Answer a);
         void deleteAnswer(int answerId);

         

         #endregion
        
        
        
    }
}