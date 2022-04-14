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
        public static List<User> contestants = new List<User>();

        public QuizContestantForm(Quiz c)
        {
            InitializeComponent();
            TheQuiz = c;           
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
                }
            }
            catch
            {
                MessageBox.Show("Could Not Connect to Quiz");
                this.Close();
            }
        }

        private void Comm_UserAdded(User u)
        {
            // Add user to list
            contestants.Add(u);

            // Add user control to form
            this.Invoke(new Action(() => { pnlContestants.Controls.Clear(); }));
            pnlContestants.Controls.Clear();
            foreach (User u2 in contestants)
            {
                ContestantControl tmp = new ContestantControl(u2);
                this.Invoke(new Action(() => { pnlContestants.Controls.Add(tmp); }));                
            }
        }
    }
}
