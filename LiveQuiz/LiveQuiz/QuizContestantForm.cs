using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Added
using System.Net.Sockets;
using System.Net;
using System.IO;
using QuizClasses;

namespace LiveQuiz
{
    public partial class QuizContestantForm : Form
    {
        Quiz TheQuiz;
        ContestantComms comm;

        public int Points = 300;
        public bool anonUser = false;
        public static List<Tuple<User, UserScore>> contestants = new List<Tuple<User, UserScore>>();
        public Dictionary<string, QuizAnswer> CurrentAnswers = new Dictionary<string, QuizAnswer>();

        public QuizContestantForm(Quiz c)
        {
            InitializeComponent();
            TheQuiz = c;
            btnAns1.Enabled = false;
            btnAns2.Enabled = false;
            btnAns3.Enabled = false;
            btnAns4.Enabled = false;
            btnAns1.Visible = false;
            btnAns2.Visible = false;
            btnAns3.Visible = false;
            btnAns4.Visible = false;

            lblTimer.Visible = false;
        }

        public QuizContestantForm(Quiz c, Anon a)
        {
            InitializeComponent();
            TheQuiz = c;
            btnAns1.Enabled = false;
            btnAns2.Enabled = false;
            btnAns3.Enabled = false;
            btnAns4.Enabled = false;
            btnAns1.Visible = false;
            btnAns2.Visible = false;
            btnAns3.Visible = false;
            btnAns4.Visible = false;
            anonUser = true;
            lblTimer.Visible = false;
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnAns1.Enabled = false;
            btnAns2.Enabled = false;
            btnAns3.Enabled = false;
            btnAns4.Enabled = false;
            btnAns1.Visible = false;
            btnAns2.Visible = false;
            btnAns3.Visible = false;
            btnAns4.Visible = false;
            lblTimer.Visible = false;
            HideAnswers();

            Button button = sender as Button;
            QuizAnswer yourAnswer = CurrentAnswers[button.Text];
            if (yourAnswer.Correct)
                lblQuestion.Text = "Correct!\nWaiting for Next Question";
            else
                lblQuestion.Text = "Incorrect!\nWaiting for Next Question";

            Tuple<User, QuizAnswer, int> response = new Tuple<User, QuizAnswer, int>(QuiznessLayer.LoggedInUser, yourAnswer, Points);
            comm.SendAnswer(response);
        }

        private void QuizContestantForm_Load(object sender, EventArgs e)
        {
            try
            {
                string ip = QuiznessLayer.GetIPbyQuiz(TheQuiz);
                if (ip == null)
                {
                    MessageBox.Show("Quiz Not Found");
                    this.Close();
                }
                else
                {
                    comm = new ContestantComms(ip);

                    // Wire up delegates
                    comm.Connected += Comm_Connected;
                    comm.ConnectionFailed += Comm_ConnectionFailed;
                    comm.UserAdded += Comm_UserAdded;
                    comm.NewQuestion += Comm_NewQuestion;
                    comm.AnswerResult += Comm_AnswerResult;
                    comm.FinalResults += Comm_FinalResults;
                    comm.GameOver += Comm_GameOver;
                }
            }
            catch
            {
                MessageBox.Show("Could Not Connect to Quiz");
                this.Close();
            }
        }

        private void Comm_FinalResults(string results)
        {
            lblQuestion.Text = results;
        }

        private void Comm_GameOver()
        {
            foreach (Tuple<User, UserScore> u2 in contestants)
            {
                if (u2 is Anon)
                {

                }
                else if (u2.Item1.Id == QuiznessLayer.LoggedInUser.Id)
                {
                    QuiznessLayer.UpdateUser(u2.Item2);
                }
            }

            this.Invoke(new Action(() => {
                MessageBox.Show("The Quiz Has Ended");
                this.Close();
            }));
        }

        private void HideAnswers()
        {
            lblAns1.Visible = false;
            lblAns2.Visible = false;
            lblAns3.Visible = false;
            lblAns4.Visible = false;
        }

        private void Comm_AnswerResult(Tuple<User, QuizAnswer, int> answer)
        {
            
        }

        private void Comm_ConnectionFailed(string servername, int port)
        {
            MessageBox.Show("Could Not Connect to Quiz");
            this.Close();
        }

        private void Comm_Connected(string servername, int port)
        {
            this.Invoke(new Action(() => { lblQuestion.Text = "Connected. Waiting for Quiz to Start"; }));
            
            if (QuiznessLayer.LoggedInUser != null)
            {
                comm.SendUserInfo(QuiznessLayer.LoggedInUser);
            }
        }

        private void Comm_NewQuestion(QuizQuestion qq)
        {
            this.Invoke(new Action(() => {

                CurrentAnswers.Clear();
                lblQuestion.Text = qq.Question;
                Points = 300;
                timer1.Start();
                lblTimer.Text = Points.ToString();
                lblTimer.Visible = true;

                if (qq.Answers.Count == 2)
                {
                    lblAns1.Text = qq.Answers[0].Answer;
                    lblAns2.Text = qq.Answers[1].Answer;

                    // Show answer labels
                    lblAns1.Visible = true;
                    lblAns2.Visible = true;

                    // Enable appropriate buttons
                    btnAns1.Text = qq.Answers[0].Answer;
                    btnAns1.Visible = true;
                    btnAns1.Enabled = true;
                    btnAns2.Text = qq.Answers[1].Answer;
                    btnAns2.Visible = true;
                    btnAns2.Enabled = true;

                    // Add to dictionary
                    CurrentAnswers.Add(qq.Answers[0].Answer, qq.Answers[0]);
                    CurrentAnswers.Add(qq.Answers[1].Answer, qq.Answers[1]);
                }
                else
                {
                    lblAns1.Text = "A) " + qq.Answers[0].Answer;
                    lblAns2.Text = "B) " + qq.Answers[1].Answer;
                    lblAns3.Text = "C) " + qq.Answers[2].Answer;
                    lblAns4.Text = "D) " + qq.Answers[3].Answer;

                    // Show answer labels
                    lblAns1.Visible = true;
                    lblAns2.Visible = true;
                    lblAns3.Visible = true;
                    lblAns4.Visible = true;

                    // Enable appropriate buttons
                    btnAns1.Text = "A";
                    btnAns1.Visible = true;
                    btnAns1.Enabled = true;
                    btnAns2.Text = "B";
                    btnAns2.Visible = true;
                    btnAns2.Enabled = true;
                    btnAns3.Text = "C";
                    btnAns3.Visible = true;
                    btnAns3.Enabled = true;
                    btnAns4.Text = "D";
                    btnAns4.Visible = true;
                    btnAns4.Enabled = true;

                    // Add to dictionary
                    CurrentAnswers.Add("A", qq.Answers[0]);
                    CurrentAnswers.Add("B", qq.Answers[1]);
                    CurrentAnswers.Add("C", qq.Answers[2]);
                    CurrentAnswers.Add("D", qq.Answers[3]);
                }
            }));            
        }

        private void Comm_UserAdded(Tuple<User, UserScore> u)
        {
            // Empty the list
            contestants.Clear();

            // Add user to list
            contestants.Add(u);

            // Add user control to form
            this.Invoke(new Action(() => { 
                pnlContestants.Controls.Clear();
                foreach (Tuple<User, UserScore> u2 in contestants)
                {
                    ContestantControl tmp = new ContestantControl(u2);
                    pnlContestants.Controls.Add(tmp);
                }
            }));
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Points -= 10;
            this.Invoke(new Action(() => { lblTimer.Text = Points.ToString(); }));

            if (Points == 0)
                timer1.Stop();
        }
    }
}
