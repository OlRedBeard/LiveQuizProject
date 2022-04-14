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
        private bool Host;
        public Quiz TheQuiz { get; set; }

        public QuizControl(Quiz q, bool host)
        {
            InitializeComponent();

            lblQuizName.Text = q.Title;
            lblTopic.Text = "Topic: " + q.Topic;
            QuizID = q.Id;
            TheQuiz = q;
            Host = host;

            if (!Host) 
            {
                lblContext.Text = "Created By: " + q.Creator.Username;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnContext.Text = "Join";
            }
            else
            {
                lblContext.Text = "Number of Questions: " + q.Questions.Count.ToString();
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                btnContext.Text = "Host";
            }
        }

        private void btnContext_Click(object sender, EventArgs e)
        {
            if (Host)
            {
                // Launch hosting window
                QuizHostForm qh = new QuizHostForm(TheQuiz);
                this.Parent.Hide();
                qh.ShowDialog();
                this.Parent.Show();
            }
            else
            {
                // Fetch room code and launch player window
                QuizContestantForm qcf = new QuizContestantForm(TheQuiz);
                this.Parent.Hide();
                qcf.ShowDialog();
                this.Parent.Show();
            }
        }
    }
}
