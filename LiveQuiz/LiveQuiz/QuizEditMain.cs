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
    public partial class QuizEditMain : Form
    {
        public Quiz theQuiz;

        public QuizEditMain(Quiz q)
        {
            InitializeComponent();
            this.theQuiz = q;
            this.Text = "Editing " + theQuiz.Title;
        }

        private void btnBasics_Click(object sender, EventArgs e)
        {
            QuizEditBasics qeb = new QuizEditBasics(theQuiz);
            this.Hide();
            qeb.ShowDialog();
            this.Show();
        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            QuestionsManual qm = new QuestionsManual(theQuiz, true);
            this.Hide();
            qm.ShowDialog();
            this.Show();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
