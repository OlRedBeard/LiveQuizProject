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
    public partial class QuizControl : UserControl
    {
        private int QuizID;

        public QuizControl(Quiz q)
        {
            InitializeComponent();

            lblQuizName.Text = q.Title;
            lblCreator.Text = "Created By: " + q.Creator;
            lblTopic.Text = "Topic: " + q.Topic;

            QuizID = q.Id;
        }

        private void btnJoinQuiz_Click(object sender, EventArgs e)
        {
            // Fire a delegate to return the quizid to the form
        }
    }
}
