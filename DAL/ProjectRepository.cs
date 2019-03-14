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
        
        #region Interface implementation
        public IEnumerable<Project> readProjects()
        {
            return ctx.Projects.AsEnumerable();
        }

        public Project readProject(int id)
        {
            return ctx.Projects
                .Include(p => p.questionnaires)
                .SingleOrDefault(p => p.id == id);
        }

        public IEnumerable<Questionnaire> readQuestionnaires()
        {
            return ctx.Questionnaires.AsEnumerable();
        }

        public void createProject(Project p)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.Projects.Add(p);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void updateProject(Project p)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.Projects.Update(p);
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.SaveChanges();
        }

        public void deleteProject(int id)
        {
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.Projects.Remove(ctx.Projects.Find(id));
            Helper.PrintDbContextTrackedEntitiesStates(ctx, "STATES (ProjectRepo.Ctx)");
            ctx.SaveChanges();
        }
        #endregion
    }
}