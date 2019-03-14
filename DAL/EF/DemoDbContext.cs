using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace DAL.EF
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext()
        {
            this.ChangeTracker.AutoDetectChangesEnabled = false;
            DemoDbInitializer.Initialize(this, false);
        }
        
        public DbSet<Question> Questions { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<IotSetup> IotSetups { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<QuestionUser> QuestionUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlite("Data Source=Demo_EF.db");
            optionsBuilder.UseLoggerFactory(new LoggerFactory(
                new[] { new DebugLoggerProvider(
                    (category, level) => category == DbLoggerCategory.Database.Command.Name
                                         && level == LogLevel.Information
                )}
            ));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Questionnaire>().Property<int>("ProjectId");
            modelBuilder.Entity<Questionnaire>().HasOne<Project>(q => q.project)
                .WithMany(p => p.questionnaires).HasForeignKey("ProjectId");
            
            modelBuilder.Entity<Question>().Property<int>("QuestionnaireId");
            modelBuilder.Entity<Question>().HasOne<Questionnaire>(q => q.questionnaire)
                .WithMany(q => q.questions).HasForeignKey("QuestionnaireId");
            
            modelBuilder.Entity<IotSetup>().Property<int>("QuestionnaireId");
            modelBuilder.Entity<IotSetup>().HasOne<Questionnaire>(q => q.questionnaire)
                .WithMany(q => q.iotSetups).HasForeignKey("QuestionnaireId");
        }

        private readonly bool delaySave = false;

        public DemoDbContext(bool isUnitOfWorkPresent)
            : this()
        {
            delaySave = isUnitOfWorkPresent;
        }

        internal int CommitChanges()
        {
            if (delaySave)
            {
                Helper.PrintDbContextTrackedEntitiesStates(this, "STATES BEFORE CommitChanges() (TO DB)");
            
                int infectedRecords = base.SaveChanges();
            
                Helper.PrintDbContextTrackedEntitiesStates(this, "STATES AFTER CommitChanges() (TO DB)");            
            
                return infectedRecords;
            }
            throw new InvalidOperationException("No UnitOfWork present, use SaveChanges instead");
        }
    }
}