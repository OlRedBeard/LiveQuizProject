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
    public partial class QuizEditBasics : Form
    {
        public Quiz theQuiz;

        public QuizEditBasics(Quiz q)
        {
            InitializeComponent();
            this.theQuiz = q;
            this.Text = theQuiz.Title + " - Edit Basics";

            txtTitle.Text = theQuiz.Title;
            txtTopic.Text = theQuiz.Topic;

            if (theQuiz.IsPublic)
                chkPublic.Checked = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            theQuiz.Title = txtTitle.Text;
            theQuiz.Topic = txtTopic.Text;
            theQuiz.IsPublic = chkPublic.Checked;

            QuiznessLayer.UpdateQuiz(theQuiz);
            this.Close();
        }
    }
}
