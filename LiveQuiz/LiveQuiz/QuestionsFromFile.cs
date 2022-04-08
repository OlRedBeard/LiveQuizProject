using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizClasses;

namespace LiveQuiz
{
    public partial class QuestionsFromFile : Form
    {
        public Quiz theQuiz;

        public QuestionsFromFile(Quiz quiz)
        {
            InitializeComponent();
            this.theQuiz = quiz;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Pipe Separated Values (*.psv)|*.psv";
            string[] fileLines;

            if (op.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = op.FileName.Split("\\").LastOrDefault();

                fileLines = File.ReadAllLines(op.FileName);
                foreach (string line in fileLines)
                {
                    string question = line.Split('|')[0];
                    string corrAnsw = line.Split('|')[1];
                    QuizQuestion qq = new QuizQuestion(question);
                    QuizAnswer qa = new QuizAnswer(corrAnsw, true);
                    qq.AddAnswer(qa);

                    for (int i = 2; i < line.Split('|').Length; i++)
                    {
                        QuizAnswer tmp = new QuizAnswer(line.Split('|')[i], false);
                        qq.AddAnswer(tmp);
                    }

                    theQuiz.AddQuestion(qq);
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            bool success = QuiznessLayer.AddQuiz(theQuiz);
            if (success)
                this.Close();
            else
                MessageBox.Show("Failed to create questions, please try again");
        }
    }
}
