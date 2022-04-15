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
    public partial class ContestantControl : UserControl
    {
        public User theuser;
        public UserScore theUserScore;

        public ContestantControl(Tuple<User, UserScore> tuple)
        {
            InitializeComponent();
            this.theuser = tuple.Item1;
            this.theUserScore = tuple.Item2;

            lblUsername.Text = theuser.Username;
            lblScore.Text = theUserScore.Score.ToString();
            lblTime.Text = theUserScore.AvgTimeToAnswer.ToString() + "s";

            lblCorr.Text = theUserScore.NumCorrect.ToString();

            int numWrong = theUserScore.NumQuestions - theUserScore.NumCorrect;
            lblInc.Text = numWrong.ToString();
        }
    }
}
