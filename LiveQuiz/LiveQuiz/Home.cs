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
            // Hide create quiz button
            btnNewQuiz.Enabled = false;
            btnNewQuiz.Visible = false;
            // Load any public quizes into the flow layout panel
            List<Quiz> pubQuizzes = QuiznessLayer.GetPublicQuizzes();

            if (pubQuizzes != null)
            {
                foreach (Quiz q in pubQuizzes)
                {
                    QuizControl cont = new QuizControl(q);
                    flpContext.Controls.Add(cont);
                }
            }
        }

        private void flpContext_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMyQuizzes_Click(object sender, EventArgs e)
        {
            // Enable Create button
            btnNewQuiz.Enabled = true;
            btnNewQuiz.Visible = true;
            // Clear FLP
            flpContext.Controls.Clear();
            // Add this user's quizzes to the FLP
        }

        private void btnMyScores_Click(object sender, EventArgs e)
        {
            // Clear FLP
            // Add this user's quiz scores to the FLP
        }
    }
}
