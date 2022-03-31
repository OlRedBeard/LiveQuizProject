﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizClasses
{
    public class UserScores
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string Username { get; set; }
        public int Score { get; set; }
    }
}
