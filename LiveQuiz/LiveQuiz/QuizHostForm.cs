using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Added using statements
using System.Net.Sockets;
using System.Net;
using QuizClasses;

namespace LiveQuiz
{
    public partial class QuizHostForm : Form
    {
        public static int port = 5000;
        public Quiz theQuiz;
        TcpListener listener;
        HostServer server;
        QuizInstance qi;
        public static List<Tuple<User, UserScore>> contestants = new List<Tuple<User, UserScore>>();
        public static List<HostServer> servers = new List<HostServer>();
        public static int numContestants = 0;
        public int numAnswers = 0;
        public int numCorr = 0;
        public static Queue<QuizQuestion> questions = new Queue<QuizQuestion>();

        public QuizHostForm(Quiz q)
        {
            InitializeComponent();
            cmbIP.DataSource = Dns.GetHostEntry(SystemInformation.ComputerName).AddressList
                .Where(x => x.AddressFamily == AddressFamily.InterNetwork).ToList();
            theQuiz = q;
            lblCode.Text = "";
            lblQuestion.Text = "";
            btnContext.Visible = false;
            btnContext.Enabled = false;
            HideAnswers();
        }

        private void HideAnswers()
        {
            lblAns1.Visible = false;
            lblAns2.Visible = false;
            lblAns3.Visible = false;
            lblAns4.Visible = false;
            lblAnswers.Visible = false;
        }

        private void ShowAnswers(int num)
        {
            lblAns1.Visible = true;
            lblAns2.Visible = true;

            if (num > 2)
            {
                lblAns1.Visible = true;
                lblAns2.Visible = true;
                lblAns3.Visible = true;
                lblAns4.Visible = true;
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress serverName = (IPAddress)cmbIP.SelectedItem;
                listener = new TcpListener(serverName, port);
                listener.Start();

                server = new HostServer(listener);

                // Wire up delegates here
                server.NewClientConnected += Server_NewClientConnected;
                server.UserAdded += Server_UserAdded;
                server.UserAnswer += Server_UserAnswer;

                // Create quiz instance
                qi = new QuizInstance();
                qi.HostIP = serverName.ToString();
                qi.Completed = false;
                qi.GetRoomCode();
                QuiznessLayer.AddInstance(theQuiz, qi);

                // Hide the IP/Starting controls
                lblIP.Visible = false;
                cmbIP.Enabled = false;
                cmbIP.Visible = false;
                btnBegin.Enabled = false;
                btnBegin.Visible = false;

                // Display the room code on the form
                lblCode.Text = qi.RoomCode;

                // Display starting information & quiz begin button
                lblQuestion.Text = "Quiz Ready, Waiting for Contestants!";
                // Shuffle questions to random order
                theQuiz.Shuffle();
                // Shuffle answers to random order
                foreach (QuizQuestion question in theQuiz.Questions)
                {
                    question.Shuffle();
                    questions.Enqueue(question);
                }                               

                // Display context button
                btnContext.Text = "Begin Quiz";
                btnContext.Enabled = true;
                btnContext.Visible = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void Server_GameOver(HostServer client)
        {
            throw new NotImplementedException();
        }

        private void Server_UserAnswer(HostServer client, Tuple<User, QuizAnswer, int> answer)
        {
            // Increase answer percentage
            numAnswers++;
            lblAnswers.Text = "Answers: " + numAnswers.ToString() + "/" + numContestants.ToString();

            // Update local controls -- THIS IS NOT WORKING, WILL NOT EVER HIT THE FIRST IF
            foreach (Tuple<User, UserScore> user in contestants)
            {
                if (user.Item1.Id == answer.Item1.Id)
                {
                    user.Item2.NumQuestions++;
                    user.Item2.TimeToAnswer = (300 - answer.Item3) / 10;

                    if (answer.Item2.Correct == true)
                    {
                        user.Item2.Score += answer.Item3;
                        user.Item2.NumCorrect++;
                        numCorr++;
                    }
                }
            }
            // Relay tuple to allow clients to do the same
            pnlContestants.Controls.Clear();
            foreach (Tuple<User, UserScore> u2 in contestants)
            {
                ContestantControl tmp = new ContestantControl(u2);
                pnlContestants.Controls.Add(tmp);

                // Send to contestants
                RelayInfo(u2);
            }
        }

        private void RelayInfo(object o)
        {
            foreach (HostServer serv in servers)
            {
                serv.SendUpdate(o);
            }
        }

        private void Server_UserAdded(HostServer client, User u)
        {
            // Create UserScore
            UserScore us = new UserScore();
            us.NumQuestions = 0;
            us.QuizName = theQuiz.Title;
            us.TimeToAnswer = 30;
            us.Score = 0;
            us.NumCorrect = 0;

            // Add user to list
            contestants.Add(new Tuple<User, UserScore>(u, us));

            // Add user control to form
            pnlContestants.Controls.Clear();
            foreach(Tuple<User, UserScore> u2 in contestants)
            {
                ContestantControl tmp = new ContestantControl(u2);
                pnlContestants.Controls.Add(tmp);

                // Send to contestants
                RelayInfo(u2);
            }
        }

        private void Server_NewClientConnected(HostServer client)
        {
            numContestants++;
            servers.Add(client);

            server = new HostServer(listener);

            // Wire up delegates here
            server.NewClientConnected += Server_NewClientConnected;
            server.UserAdded += Server_UserAdded; 
            server.UserAnswer += Server_UserAnswer;
        }

        private void QuizHostForm_Load(object sender, EventArgs e)
        {

        }

        private void QuizHostForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (qi != null)
            {
                QuiznessLayer.EndInstance(qi);
                RelayInfo(0);
            }
        }

        private void btnContext_Click(object sender, EventArgs e)
        {
            if (btnContext.Text == "Begin Quiz" || btnContext.Text == "Next Question")
            {
                // Dequeue the next question
                QuizQuestion qq = questions.Dequeue();

                // Reset counters
                numCorr = 0;
                numAnswers = 0;

                // Track answers vs number of contestants
                lblAnswers.Text = "Answers: " + numAnswers.ToString() + "/" + numContestants.ToString();
                lblAnswers.Visible = true;

                // Display the question and answers
                lblQuestion.Text = qq.Question;

                if (qq.Answers.Count == 2)
                {
                    lblAns1.Text = qq.Answers[0].Answer;
                    lblAns2.Text = qq.Answers[1].Answer;
                }
                else
                {
                    lblAns1.Text = "A) " + qq.Answers[0].Answer;
                    lblAns2.Text = "B) " + qq.Answers[1].Answer;
                    lblAns3.Text = "C) " + qq.Answers[2].Answer;
                    lblAns4.Text = "D) " + qq.Answers[3].Answer;
                }

                // Display the needed labels
                ShowAnswers(qq.Answers.Count);

                // Relay the question to all users
                RelayInfo(qq);

                // Change the context button
                btnContext.Text = "End Question";
            }
            else if (btnContext.Text == "End Question")
            {
                // Show details
                lblQuestion.Text = "Correct Answers: " + numCorr.ToString() + "\nIncorrect Answers: " + (numContestants - numCorr).ToString();
                HideAnswers();
                
                // Change the context button
                if (questions.Count > 0)
                    btnContext.Text = "Next Question";
                else
                    btnContext.Text = "Final Results";
            }
            else if (btnContext.Text == "Final Results")
            {
                List<Tuple<User, UserScore>> HighScores = GetHighScores();
                string scoreDisplay = "";

                for (int i = 0; i < HighScores.Count; i++)
                {
                    Tuple<User, UserScore> tmp = HighScores[i];
                    scoreDisplay += $"#{i + 1}: {tmp.Item1.Username} ({tmp.Item2.Score} pts)\n";
                }

                lblQuestion.Text = scoreDisplay;
                RelayInfo(scoreDisplay);
                btnContext.Text = "End Quiz";
            }
            else if (btnContext.Text == "End Quiz")
            {
                // Complete Instance
                QuiznessLayer.EndInstance(qi);
                // Relay Information
                RelayInfo(0);
                // Close Form
                this.Close();
            }
        }

        private List<Tuple<User, UserScore>> GetHighScores()
        {
            List<Tuple<User, UserScore>> highScores = new List<Tuple<User,UserScore>>();

            if (contestants.Count == 1)
                highScores = contestants;
            else if (contestants.Count == 2)
            {
                Tuple<User, UserScore> first = null;
                Tuple<User, UserScore> second = null;
                int hs = 0;

                foreach (Tuple<User, UserScore> pair in contestants)
                {
                    if (pair.Item2.Score > hs)
                    {
                        if (first == null)
                        {
                            first = pair;
                        }
                        else
                        {
                            second = first;
                            first = pair;
                        }
                    }
                    else
                    {
                        second = pair;
                    }
                }
                highScores.Add(first);
                highScores.Add(second);
            }
            else
            {
                Tuple<User, UserScore> first = null;
                Tuple<User, UserScore> second = null;
                Tuple<User, UserScore> third = null;

                int hs1 = 0;
                int hs2 = 0;
                int hs3 = 0;

                foreach (Tuple<User, UserScore> pair in contestants)
                {
                    if (pair.Item2.Score > hs1)
                    {
                        if (first == null)
                        {
                            first = pair;
                            hs1 = pair.Item2.Score;
                        }
                        else
                        {
                            third = second;
                            second = first;
                            first = pair;
                            
                            hs1 = pair.Item2.Score;
                            hs2 = second.Item2.Score;
                            if (third != null)
                                hs3 = third.Item2.Score;
                        }
                    }
                    else if (pair.Item2.Score > hs2)
                    {
                        if (second == null)
                        {
                            second = pair;
                            hs2 = second.Item2.Score;
                        }
                        else
                        {
                            third = second;
                            second = pair;

                            hs2 = second.Item2.Score;
                            hs3 = third.Item2.Score;
                        }
                    }
                    else if (pair.Item2.Score < hs3)
                    {
                        third = pair;
                        hs3 = third.Item2.Score;
                    }
                }
                highScores.Add(first);
                highScores.Add(second);
                highScores.Add(third);
            }

            return highScores;
        }
    }
}
