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
        // Fields 
        public DbSet<Field> fields { get; set; }
        public DbSet<TextField> textFields { get; set; }
        public DbSet<ImageField> imageFields { get; set; }
        public DbSet<MapField> mapFields { get; set; }
        public DbSet<QuestionField> questionFields { get; set; }
        public DbSet<VideoField> videoFields { get; set; }
        // Likes
        public DbSet<Like> likes { get; set; }
        public DbSet<IdeaLike> ideaLikes { get; set; }
        public DbSet<ProjectLike> projectLikes { get; set; }
        public DbSet<ReactionLike> answerLikes { get; set; }
        public DbSet<IotVote> iotLikes { get; set; }

        //Project
        public DbSet<Project> projects { get; set; }
        public DbSet<Phase> phases { get; set; }
        
        //Ideation
        public DbSet<Ideation> ideations { get; set; }
        public DbSet<IdeationQuestion> ideationQuestions { get; set; }
        public DbSet<Idea> ideas { get; set; }
        public DbSet<Reaction> answers { get; set; }
        
        //Questionnaire 
        public DbSet<Questionnaire> questionnaires { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<Option> options { get; set; }
        public DbSet<QuestionUser> questionUsers { get; set; }


         //Iotset
        public DbSet<IotSetup> iotSetups { get; set; }
        
        //User
        public DbSet<User> users { get; set; }


       
        

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

          /*  modelBuilder.Entity<Questionnaire>().Property<int>("ProjectId");
            modelBuilder.Entity<Questionnaire>().HasOne<Project>(q => q.project).WithMany(p => p.questionnaires)
                .HasForeignKey("ProjectId");
            
            modelBuilder.Entity<Phase>().Property<int>("projectId"); // shadow FK naar Project
            modelBuilder.Entity<Phase>().HasOne<Project>(p => p.project).WithMany(f => f.phases)
                .HasForeignKey("projectId");
            
            modelBuilder.Entity<Ideation>().Property<int>("projectId"); // shadow FK naar Project
            modelBuilder.Entity<Ideation>().HasOne<Project>(p => p.project).WithMany(i => i.ideations)
                .HasForeignKey("projectId");

            
            modelBuilder.Entity<Question>().Property<int>("QuestionnaireId");
            modelBuilder.Entity<Question>().HasOne<Questionnaire>(q => q.questionnaire)
                .WithMany(q => q.questions).HasForeignKey("QuestionnaireId");
            
            modelBuilder.Entity<Ideation>().Property<int>("projectId"); // shadow FK naar Project
            modelBuilder.Entity<Ideation>().HasOne<Project>(p => p.project).WithMany(i => i.ideations)
                .HasForeignKey("projectId");
            
          
            
            // Fields
            modelBuilder.Entity<Field>().Property<int>("ideaId"); // shadow FK naar Idea
            modelBuilder.Entity<Field>().HasOne<Idea>(i => i.idea).WithMany(f => f.fields)
                .HasForeignKey("ideaId");
            
              modelBuilder.Entity<Field>().Property<int>("ideationId"); // shadow FK naar Ideation
            modelBuilder.Entity<Field>().HasOne<Ideation>(i => i.ideation).WithMany(f => f.fields)
                .HasForeignKey("ideationId");
          
            modelBuilder.Entity<QuestionField>().Property<int>("questionId"); // shadow FK naar Ideation
            modelBuilder.Entity<QuestionField>().HasOne<Question>(q =>q.question).WithMany(f => f.fields)
                .HasForeignKey("questionId");
            
            
            
            // Likes 
            modelBuilder.Entity<IdeaLike>().Property<int>("ideaId"); // shadow FK naar Idea
            modelBuilder.Entity<IdeaLike>().HasOne<Idea>(i => i.Idea).WithMany(f => f.ideaLikes)
                .HasForeignKey("ideaId");
            modelBuilder.Entity<IdeaLike>().Property<int>("userId"); // shadow FK naar User
            modelBuilder.Entity<IdeaLike>().HasOne<User>(u => u.user).WithMany(i => i.ideaLikes)
                .HasForeignKey("userId");
            modelBuilder.Entity<ProjectLike>().Property<int>("projectId"); // shadow FK naar Idea
            modelBuilder.Entity<ProjectLike>().HasOne<Project>(p => p.Project).WithMany(i => i.projectLikes)
                .HasForeignKey("projectId");
            modelBuilder.Entity<ProjectLike>().Property<int>("userId"); // shadow FK naar User
            modelBuilder.Entity<ProjectLike>().HasOne<User>(u => u.user).WithMany(i => i.projectLikes)
                .HasForeignKey("userId"); modelBuilder.Entity<IdeaLike>().Property<int>("ideaId"); // shadow FK naar Idea
            modelBuilder.Entity<ReactionLike>().Property<int>("reactionId"); // shadow FK naar User
            modelBuilder.Entity<ReactionLike>().HasOne<Reaction>(r => r.reaction).WithMany(i => i.reactionLikes)
                .HasForeignKey("reactionId");
            
            modelBuilder.Entity<ReactionLike>().Property<int>("userId"); // shadow FK naar User
            modelBuilder.Entity<ReactionLike>().HasOne<User>(u => u.user).WithMany(i => i.reactionLikes)
                .HasForeignKey("userId");
           // IotLikes
           modelBuilder.Entity<IotVote>().Property<int>("questioneId"); // shadow FK naar User
           modelBuilder.Entity<IotVote>().HasOne<Question>(q => q.question).WithMany(i => i.iotVotes)
               .HasForeignKey("questionId");
            
           modelBuilder.Entity<IotVote>().Property<int>("userId"); // shadow FK naar User
           modelBuilder.Entity<IotVote>().HasOne<User>(u => u.user).WithMany(i => i.iotVotes)
               .HasForeignKey("userId");

           
            
            modelBuilder.Entity<Idea>().Property<int>("ideationId"); // shaodow FK naar Ideation 
            modelBuilder.Entity<Idea>().Property<int>("userId"); // shaodow FK naar User

            modelBuilder.Entity<Idea>().HasOne<Ideation>(i => i.ideation).WithMany(i => i.ideas)
                .HasForeignKey("ideationId");
            modelBuilder.Entity<Idea>().HasOne<User>(u => u.user).WithMany(i => i.ideas)
                .HasForeignKey("userId");
            
            modelBuilder.Entity<IdeationQuestion>().Property<int>("ideationId"); // shaodow FK naar Ideation 
            modelBuilder.Entity<IdeationQuestion>().HasOne<Ideation>(i => i.ideation).WithMany(q => q.questions)
                .HasForeignKey("ideationId");
            
            modelBuilder.Entity<Reaction>().Property<int>("ideaId"); // shaodow FK naar Idea
            modelBuilder.Entity<Reaction>().Property<int>("userId"); // shaodow FK naar User
            
            modelBuilder.Entity<Reaction>().HasOne<Idea>(i => i.idea).WithMany(a => a.reactions)
                .HasForeignKey("ideaId");
            modelBuilder.Entity<Reaction>().HasOne<User>(u => u.user).WithMany(a=> a.reactions)
                .HasForeignKey("userId");
                
                */
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