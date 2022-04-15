using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizClasses;

namespace LiveQuiz
{
    public partial class ScoreControl : UserControl
    {
        UserScore theScore;

        public ScoreControl(UserScore score)
        {
            InitializeComponent();
            this.theScore = score;

            lblQuizName.Text = "Quiz: " + theScore.QuizName;
            lblScore.Text = "Score: " + theScore.Score.ToString();
            lblNumCorr.Text = "Correct Answers: " + theScore.NumCorrect.ToString() + "/" + theScore.NumQuestions.ToString();
            lblTTA.Text = "Avg. Answer Time: " + theScore.AvgTimeToAnswer.ToString() + "s";
        }
    }
}
