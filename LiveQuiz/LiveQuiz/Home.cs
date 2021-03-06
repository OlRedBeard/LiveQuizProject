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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.Text = "Welcome to Quiz-Face Showcase, " + QuiznessLayer.LoggedInUser.Username + "!";

            SetHome();
        }

        private void btnMyQuizzes_Click(object sender, EventArgs e)
        {
            SetMyQuiz();
        }


        private void btnMyScores_Click(object sender, EventArgs e)
        {
            SetScores();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetHome();
        }
        private void btnNewQuiz_Click(object sender, EventArgs e)
        {
            CreateQuiz cq = new CreateQuiz();
            this.Hide();
            cq.ShowDialog();
            this.Show();
        }

        private void btnJoinCode_Click(object sender, EventArgs e)
        {
            Quiz tmp = QuiznessLayer.GetQuizbyCode(txtCode.Text);
            QuizContestantForm qcf = new QuizContestantForm(tmp);
            this.Hide();
            qcf.ShowDialog();
            this.Show();
        }

        private void SetHome()
        {
            // Clear FLP
            flpContext.Controls.Clear();
            // Hide create quiz button
            btnNewQuiz.Enabled = false;
            btnNewQuiz.Visible = false;
            // Change the labels
            lblContext.Text = "Join a Public Quiz!";
            // Load any public quizes into the flow layout panel
            List<Quiz> pubQuizzes = QuiznessLayer.GetPublicQuizzes(); // CHANGE THIS!!

            if (pubQuizzes != null)
            {
                foreach (Quiz q in pubQuizzes)
                {
                    QuizControl cont = new QuizControl(q, false);
                    cont.JoinQuiz += Cont_JoinQuiz;
                    flpContext.Controls.Add(cont);
                }
            }
        }

        private void SetMyQuiz()
        {
            // Clear FLP
            flpContext.Controls.Clear();
            // Enable Create button
            btnNewQuiz.Enabled = true;
            btnNewQuiz.Visible = true;
            // Change the labels
            lblContext.Text = "Your Created Quizzes!";
            // Add this user's quizzes to the FLP
            List<Quiz> myQuizzes = QuiznessLayer.GetYourQuizzes();

            if (myQuizzes != null)
            {
                foreach (Quiz q in myQuizzes)
                {
                    QuizControl cont = new QuizControl(q, true);
                    cont.EditQuiz += Cont_EditQuiz;
                    cont.DeleteQuiz += Cont_DeleteQuiz;
                    cont.HostQuiz += Cont_HostQuiz;
                    flpContext.Controls.Add(cont);
                }
            }
        }

        private void SetScores()
        {
            // Clear FLP
            flpContext.Controls.Clear();
            // Hide create quiz button
            btnNewQuiz.Enabled = false;
            btnNewQuiz.Visible = false;
            // Change the labels
            lblContext.Text = "Your Quiz Scores!";
            // Add this user's quiz scores to the FLP
            List<UserScore> myScores = QuiznessLayer.LoggedInUser.UserScores;

            if (myScores != null)
            {
                foreach (UserScore q in myScores)
                {
                    // Add the score control to the FLP
                    ScoreControl sc = new ScoreControl(q);
                    flpContext.Controls.Add(sc);
                }
            }
        }

        private void Cont_JoinQuiz(Quiz q)
        {
            QuizContestantForm qcf = new QuizContestantForm(q);
            this.Hide();
            qcf.ShowDialog();
            this.Show();
            SetHome();
        }

        private void Cont_EditQuiz(Quiz q)
        {
            QuizEditMain qem = new QuizEditMain(q);
            this.Hide();
            qem.ShowDialog();
            this.Show();
            SetMyQuiz();
        }
        private void Cont_HostQuiz(Quiz q)
        {
            QuizHostForm qh = new QuizHostForm(q);
            this.Hide();
            qh.ShowDialog();
            this.Show();
            SetMyQuiz();
        }

        private void Cont_DeleteQuiz()
        {
            SetMyQuiz();
        }
    }
}
