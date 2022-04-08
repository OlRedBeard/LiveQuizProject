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

        public QuizControl(Quiz q, bool host)
        {
            InitializeComponent();

            lblQuizName.Text = q.Title;
            lblTopic.Text = "Topic: " + q.Topic;
            QuizID = q.Id;
            Host = host;

            if (!Host) 
            {
                lblContext.Text = "Created By: " + q.Creator;
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
                // Generate quiz instance, provide "room code", and launch hosting window
            }
            else
            {
                // Fetch room code and launch player window
            }
        }
    }
}
