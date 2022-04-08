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
                    flpContext.Controls.Add(cont);
                }
            }
        }

        private void btnMyScores_Click(object sender, EventArgs e)
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
                foreach(UserScore q in myScores)
                {
                    // Add the score control to the FLP
                }
            }
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
            List<Quiz> pubQuizzes = QuiznessLayer.GetPublicQuizzes();

            if (pubQuizzes != null)
            {
                foreach (Quiz q in pubQuizzes)
                {
                    QuizControl cont = new QuizControl(q, false);
                    flpContext.Controls.Add(cont);
                }
            }
        }

    }
}
