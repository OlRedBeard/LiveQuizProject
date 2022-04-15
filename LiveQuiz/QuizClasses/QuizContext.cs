using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace QuizClasses
{
    public class QuizContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserScore> Scores { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<QuizQuestion> Questions { get; set; }
        public DbSet<QuizAnswer> Answers { get; set; }
        public DbSet<QuizInstance> Instances { get; set; }
        public DbSet<Anon> AnonUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"server=B231-14;database=QuizFaceDB;user id=QuizFace;password=P@$$word!");
        }
    }
}
