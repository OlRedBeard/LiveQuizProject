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
    public partial class CreateQuiz : Form
    {
        public CreateQuiz()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtTopic.Text == "")
                MessageBox.Show("Enter a Title and Topic");
            else
            {
                Quiz newQuiz = new Quiz(QuiznessLayer.LoggedInUser, chkPublic.Checked, txtTitle.Text, txtTopic.Text);
                if (rdoFile.Checked)
                {
                    // Open file upload window
                    QuestionsFromFile qf = new QuestionsFromFile(newQuiz);
                    this.Hide();
                    qf.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Open manual question adding window
                }
            }
        }
    }
}
