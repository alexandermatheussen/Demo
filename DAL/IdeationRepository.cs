using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class IdeationRepository : IIdeationRepository
    {
        private readonly DemoDbContext ctx;
        public IdeationRepository()
        {
            ctx = new DemoDbContext();
        }

        public IdeationRepository(UnitOfWork unitOfWork)
        {
            if(unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");
            ctx = unitOfWork.Context;
        }
        
        public IEnumerable<Ideation> readIdeations(int projectId)
        {
            return ctx.ideations.Include(p => p.project).Where(p => p.project.projectId == projectId);
        }

        public void createIdeation(Ideation i)
        {
            throw new System.NotImplementedException();
        }

        public Ideation readIdeation(int id)
        {
            throw new System.NotImplementedException();
        }

        public void updateIdeation(Ideation i)
        {
            throw new System.NotImplementedException();
        }

        public void deleteIdeation(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IdeationQuestion> readIdeationsQuestions(int ProjectId)
        {
            return ctx.ideationQuestions.Include(i => i.ideation).Where(i => i.ideation.project.projectId == ProjectId);

        }

        public void createIdeationQuestion(IdeationQuestion i)
        {
            throw new System.NotImplementedException();
        }

        public IdeationQuestion readIdeationQuestion(int id)
        {
            throw new System.NotImplementedException();
        }

        public void updateIdeationQuestion(IdeationQuestion i)
        {
            throw new System.NotImplementedException();
        }

        public void deleteIdeationQuestion(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Idea> readIdeas(int ideationId)
        {
            return ctx.ideas.Include(i => i.ideation).Include(i => i.user).Where( i => i.ideation.ideationId == ideationId);
        }

        #region Idea
        public void createIdea(Idea i)
        {

            ctx.ideas.Add(i);           
            ctx.SaveChanges();
            Console.WriteLine("Opslagen gelukt!");


        }
        public void createIdea(ICollection<Field> fields)
        {
            Idea i = new Idea();
            i.fields = fields;
            ctx.ideas.Add(i);
            ctx.SaveChanges();
            Console.WriteLine("Opslagen gelukt!");
        }
        

        public Idea readIdea(int ideaId)
        {
            return ctx.ideas.Include(i => i.fields).SingleOrDefault(i => i.ideaId == ideaId);
        }

        public void updateIdea(Idea i)
        {
            throw new NotImplementedException();
        }

        public void deleteIdea(int ideaId)
        {
            throw new NotImplementedException();
        }
        

        #endregion
       
    }
}