using System;
using System.Collections.Generic;
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

        public IEnumerable<Ideation> getIdeations(int projectId)
        {
           return  ideationRepo.readIdeations(projectId);
        }
        
        public IEnumerable<IdeationQuestion> getIdeationQuestions(int projectId)
        {
            return  ideationRepo.readIdeationsQuestions(projectId);
        }

        public IEnumerable<Idea> getIdeas(int ideationId)
        {
            return ideationRepo.readIdeas(ideationId);
        }
    }
}