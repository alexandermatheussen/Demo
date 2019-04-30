using System;
using System.Collections.Generic;
using System.Drawing;
using BL.Managers;
using DAL;
using Domain;

namespace BL
{
    public class IdeationManager : IIdeationManager
    {
        private IIdeationRepository ideationRepo;
        
        public IdeationManager()
        {
            ideationRepo = new IdeationRepository();
        }

        public IdeationManager(UnitOfWorkManager unitOfWorkManager)
        {
            if (unitOfWorkManager == null)
            {
                throw new ArgumentException("unitOfWorkManager");
            }
            ideationRepo = new IdeationRepository(unitOfWorkManager.UnitOfWork);
        }

        public Ideation getIdeation(int ideationId)
        {
            return ideationRepo.readIdeation(ideationId);
        }

        public IEnumerable<Ideation> getIdeations(int projectId)
        {
           return  ideationRepo.readIdeations(projectId);
        }
        
        public IEnumerable<IdeationQuestion> GetIdeationQuestionsForProject(int projectId)
        {
            return  ideationRepo.ReadIdeationQuestionsForProject(projectId);
        }

        public IEnumerable<IdeationQuestion> GetIdeationQuestions(int ideationId)
        {
            return ideationRepo.ReadIdeationQuestions(ideationId);
        }


        #region Ideas
        public IEnumerable<Idea> getIdeas(int ideationId)
        {
            return ideationRepo.readIdeas(ideationId);
        }

        public void createIdea(Idea i)
        {
            ideationRepo.createIdea(i);        }

        public void createIdea(ICollection<Field> fields)
        {
            ideationRepo.createIdea(fields);        }

        public Idea getIdea(int id)
        {
           return ideationRepo.readIdea(id);
        }

        #endregion
        
        
        
    }
}