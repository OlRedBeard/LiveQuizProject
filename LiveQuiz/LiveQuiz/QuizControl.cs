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

        public event EditEventHandler EditQuiz;
        public delegate void EditEventHandler(Quiz q);

        public event DeleteEventHandler DeleteQuiz;
        public delegate void DeleteEventHandler();

        public event HostEventHandler HostQuiz;
        public delegate void HostEventHandler(Quiz q);

        public event JoinEventHandler JoinQuiz;
        public delegate void JoinEventHandler(Quiz q);

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
                HostQuiz(TheQuiz);
            else
                JoinQuiz(TheQuiz);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditQuiz(TheQuiz);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Event to remove quiz
        }
    }
}
