﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace QuizClasses
{
    public class QuizContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"server=B231-14;database=QuizFaceDB;user id=QuizFace;password=P@$$word!");
        }
    }
}
