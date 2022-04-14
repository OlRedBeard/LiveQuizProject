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
        public static List<User> contestants = new List<User>();
        public static List<HostServer> servers = new List<HostServer>();
        public static int numContestants = 0;
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
                foreach (QuizQuestion question in theQuiz.Questions)
                {
                    question.Shuffle();
                    questions.Enqueue(question);
                }

                theQuiz.Shuffle();
                

                // Display context button
                btnContext.Text = "Begin Quiz";
                btnContext.Enabled = true;
                btnContext.Visible = true;
            }
            catch (Exception ex)
            {

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
            // Add user to list
            contestants.Add(u);

            // Add user control to form
            pnlContestants.Controls.Clear();
            foreach(User u2 in contestants)
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
        }

        private void QuizHostForm_Load(object sender, EventArgs e)
        {

        }

        private void QuizHostForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (qi != null)
            {
                QuiznessLayer.EndInstance(qi);
            }
        }

        private void btnContext_Click(object sender, EventArgs e)
        {
            if (btnContext.Text == "Begin Quiz")
            {
                // Dequeue the next question
                QuizQuestion qq = questions.Dequeue();

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

                // Relay the question to all users
            }
            else if (btnContext.Text == "Begin Quiz")
            {
                // 
            }
        }
    }
}
