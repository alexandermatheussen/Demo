using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DemoDbContext ctx;

        public ProjectRepository()
        {
            ctx = new DemoDbContext();
        }

        public ProjectRepository(UnitOfWork unitOfWork)
        {
            if(unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");
            ctx = unitOfWork.Context;
        }
        
        #region Projects
        public IEnumerable<Project> readProjects()
        {
            return ctx.projects.AsEnumerable();
        }

        public Project readProject(int id)
        {
            return ctx.projects
                .Include(p => p.questionnaires)
                .SingleOrDefault(p => p.id == id);
        }

        public IEnumerable<Questionnaire> readQuestionnaires()
        {
            return ctx.questionnaires.AsEnumerable();
        }

        public void createProject(Project p)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.projects.Add(p);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void updateProject(Project p)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.projects.Update(p);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void deleteProject(int id)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.projects.Remove(ctx.projects.Find(id));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.SaveChanges();
        }
        #endregion
    }
}