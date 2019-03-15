using System.Collections.Generic;
using Domain;

namespace BL
{
    public interface IIdeationManager
    {
        IEnumerable<Ideation> getIdeations(int projectId);
        IEnumerable<IdeationQuestion> getIdeationQuestions(int projectId);
        
        IEnumerable<Idea> getIdeas(int ideationId);

        
        

        
        
    }
}