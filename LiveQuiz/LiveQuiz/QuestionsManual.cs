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
    public partial class QuestionsManual : Form
    {
        public bool isEdit;
        public Quiz theQuiz;
        public QuizQuestion theQuestion;

        public QuestionsManual(Quiz q, bool edit)
        {
            InitializeComponent();
            this.theQuiz = q;
            isEdit = edit;
            this.Text = theQuiz.Title + " - Add Questions";

            if (isEdit)
            {
                lstQuestions.DataSource = theQuiz.Questions;
                btnContext.Text = "Edit Question";
                btnDelete.Visible = true;
                btnEditAdd.Visible = true;
            }
        }

        private void rdoTF_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTF.Checked)
            {
                lblAns3.Visible = false;
                lblAns4.Visible = false;
                txtAns3.Enabled = false;
                txtAns4.Enabled = false;
                txtAns3.Visible = false;
                txtAns4.Visible = false;
            }
            else
            {
                lblAns3.Visible = true;
                lblAns4.Visible = true;
                txtAns3.Enabled = true;
                txtAns4.Enabled = true;
                txtAns3.Visible = true;
                txtAns4.Visible = true;
            }
        }

        private void btnContext_Click(object sender, EventArgs e)
        {
            if (btnContext.Text == "Add Question")
            {
                if (txtQuestion.Text == "")
                    MessageBox.Show("Enter a question body to proceed");
                else
                {
                    if (rdoTF.Checked)
                    {
                        if (txtAns1.Text == "" || txtAns2.Text == "")
                            MessageBox.Show("Please provide all required answers");
                        else
                        {
                            QuizQuestion qq = new QuizQuestion(txtQuestion.Text);

                            QuizAnswer qa = new QuizAnswer(txtAns1.Text, true);
                            qq.AddAnswer(qa);
                            QuizAnswer qa2 = new QuizAnswer(txtAns2.Text, false);
                            qq.AddAnswer(qa2);

                            theQuiz.AddQuestion(qq);

                            UpdateList();
                            ClearFields();
                        }
                    }
                    else
                    {
                        if (txtAns1.Text == "" || txtAns2.Text == "" || txtAns3.Text == "" || txtAns4.Text == "")
                            MessageBox.Show("Please provide all required answers");
                        else
                        {
                            QuizQuestion qq = new QuizQuestion(txtQuestion.Text);

                            QuizAnswer qa = new QuizAnswer(txtAns1.Text, true);
                            qq.AddAnswer(qa);
                            QuizAnswer qa2 = new QuizAnswer(txtAns2.Text, false);
                            qq.AddAnswer(qa2);
                            QuizAnswer qa3 = new QuizAnswer(txtAns3.Text, false);
                            qq.AddAnswer(qa3);
                            QuizAnswer qa4 = new QuizAnswer(txtAns4.Text, false);
                            qq.AddAnswer(qa4);

                            theQuiz.AddQuestion(qq);

                            UpdateList();
                            ClearFields();
                        }
                    }
                }
            }
            else if (btnContext.Text == "Edit Question")
            {
                if (txtQuestion.Text == "")
                    MessageBox.Show("Enter a question body to proceed");
                else
                {
                    if (rdoTF.Checked)
                    {
                        if (txtAns1.Text == "" || txtAns2.Text == "")
                            MessageBox.Show("Please provide all required answers");
                        else
                        {
                            QuizQuestion old = (QuizQuestion)lstQuestions.SelectedItem;
                            old.Answers.Clear();
                            theQuiz.Questions.Remove(old);

                            QuizQuestion qq = new QuizQuestion(txtQuestion.Text);

                            QuizAnswer qa = new QuizAnswer(txtAns1.Text, true);
                            qq.AddAnswer(qa);
                            QuizAnswer qa2 = new QuizAnswer(txtAns2.Text, false);
                            qq.AddAnswer(qa2);

                            theQuiz.AddQuestion(qq);

                            UpdateList();
                            ClearFields();
                        }
                    }
                    else
                    {
                        if (txtAns1.Text == "" || txtAns2.Text == "" || txtAns3.Text == "" || txtAns4.Text == "")
                            MessageBox.Show("Please provide all required answers");
                        else
                        {
                            QuizQuestion old = (QuizQuestion)lstQuestions.SelectedItem;
                            old.Answers.Clear();
                            theQuiz.Questions.Remove(old);

                            QuizQuestion qq = new QuizQuestion(txtQuestion.Text);

                            QuizAnswer qa = new QuizAnswer(txtAns1.Text, true);
                            qq.AddAnswer(qa);
                            QuizAnswer qa2 = new QuizAnswer(txtAns2.Text, false);
                            qq.AddAnswer(qa2);
                            QuizAnswer qa3 = new QuizAnswer(txtAns3.Text, false);
                            qq.AddAnswer(qa3);
                            QuizAnswer qa4 = new QuizAnswer(txtAns4.Text, false);
                            qq.AddAnswer(qa4);

                            theQuiz.AddQuestion(qq);

                            UpdateList();
                            ClearFields();
                        }
                    }
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                bool success = QuiznessLayer.AddQuiz(theQuiz);
                if (success)
                    this.Close();
                else
                    MessageBox.Show("Failed to create questions, please try again");
            }
            else
            {
                bool success = QuiznessLayer.UpdateQuiz(theQuiz);
                if (success)
                    this.Close();
                else
                    MessageBox.Show("Failed to create questions, please try again");

            }
        }

        private void UpdateList()
        {
            lstQuestions.DataSource = null;
            lstQuestions.DataSource = theQuiz.Questions;
        }

        private void ClearFields()
        {
            txtQuestion.Text = "";
            txtAns1.Text = "";
            txtAns2.Text = "";
            txtAns3.Text = "";
            txtAns4.Text = "";
        }

        private void lstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedItem != null)
            {
                btnContext.Enabled = true;

                theQuestion = (QuizQuestion)lstQuestions.SelectedItem;
                txtQuestion.Text = theQuestion.Question;
                
                if (theQuestion.Answers.Count == 2)
                {
                    rdoTF.Checked = true;

                    for (int i = 0; i < theQuestion.Answers.Count; i++)
                    {
                        if (theQuestion.Answers[i].Correct)
                            txtAns1.Text = theQuestion.Answers[i].Answer;
                        else
                            txtAns2.Text = theQuestion.Answers[i].Answer;
                    }
                }
                else
                {
                    rdoMC.Checked = true;

                    for (int i = 0; i < theQuestion.Answers.Count; i++)
                    {
                        if (theQuestion.Answers[i].Correct)
                            txtAns1.Text = theQuestion.Answers[i].Answer;
                        else
                        {
                            if (txtAns2.Text == "")
                                txtAns2.Text = theQuestion.Answers[i].Answer;
                            else if (txtAns3.Text == "")
                                txtAns3.Text = theQuestion.Answers[i].Answer;
                            else
                                txtAns4.Text = theQuestion.Answers[i].Answer;
                        }
                    }
                }
            }
            else
            {
                btnContext.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedItem != null)
            {
                QuizQuestion question = (QuizQuestion)lstQuestions.SelectedItem;
                theQuiz.Questions.Remove(question);
                QuiznessLayer.DeleteQuestion(question);
                UpdateList();
            }
        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            btnContext.Text = "Add Question";
            ClearFields();
        }
    }
}
