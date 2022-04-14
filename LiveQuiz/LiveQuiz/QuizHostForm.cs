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
        public static List<HostServer> contestants = new List<HostServer>();

        public QuizHostForm(Quiz q)
        {
            InitializeComponent();
            cmbIP.DataSource = Dns.GetHostEntry(SystemInformation.ComputerName).AddressList
                .Where(x => x.AddressFamily == AddressFamily.InterNetwork).ToList();
            theQuiz = q;
            lblCode.Text = "";
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
            }
            catch
            {

            }
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
    }
}
