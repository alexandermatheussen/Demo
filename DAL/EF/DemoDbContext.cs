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

        #region Sets
        public DbSet<Question> questions { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Questionnaire> questionnaires { get; set; }
        public DbSet<IotSetup> iotSetups { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<QuestionUser> questionUsers { get; set; }
        public DbSet<Option> options { get; set; }
        
        public DbSet<Phase> phases { get; set; }

        public DbSet<Ideation> ideations { get; set; }
        public DbSet<IdeationQuestion> ideationQuestions { get; set; }
        public DbSet<Idea> ideas { get; set; }
        public DbSet<Answer> answers { get; set; }
        

        #endregion

        

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
            
            modelBuilder.Entity<IotSetup>().Property<int>("QuestionId");
            modelBuilder.Entity<IotSetup>().HasOne(i => i.question)
                .WithOne(q => q.IotSetup).HasForeignKey<IotSetup>("QuestionId"); 
            
            modelBuilder.Entity<Ideation>().Property<int>("projectId"); // shadow FK naar Project
            modelBuilder.Entity<Ideation>().HasOne<Project>(p => p.project).WithMany(i => i.ideations)
                .HasForeignKey("projectId");

            modelBuilder.Entity<Phase>().Property<int>("projectId"); // shadow FK naar Project
            modelBuilder.Entity<Phase>().HasOne<Project>(p => p.project).WithMany(f => f.phases)
                .HasForeignKey("projectId");
            
            modelBuilder.Entity<Idea>().Property<int>("ideationId"); // shaodow FK naar Ideation 
            modelBuilder.Entity<Idea>().Property<int>("userId"); // shaodow FK naar User

            modelBuilder.Entity<Idea>().HasOne<Ideation>(i => i.ideation).WithMany(i => i.ideas)
                .HasForeignKey("ideationId");
            modelBuilder.Entity<Idea>().HasOne<User>(u => u.user).WithMany(i => i.ideas)
                .HasForeignKey("userId");
            
            modelBuilder.Entity<IdeationQuestion>().Property<int>("ideationId"); // shaodow FK naar Ideation 
            modelBuilder.Entity<IdeationQuestion>().HasOne<Ideation>(i => i.ideation).WithMany(q => q.questions)
                .HasForeignKey("ideationId");
            
            modelBuilder.Entity<Answer>().Property<int>("ideaId"); // shaodow FK naar Idea
            modelBuilder.Entity<Answer>().Property<int>("userId"); // shaodow FK naar User
            
            modelBuilder.Entity<Answer>().HasOne<Idea>(i => i.idea).WithMany(a => a.answers)
                .HasForeignKey("ideaId");
            modelBuilder.Entity<Answer>().HasOne<User>(u => u.user).WithMany(a=> a.answers)
                .HasForeignKey("userId");
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