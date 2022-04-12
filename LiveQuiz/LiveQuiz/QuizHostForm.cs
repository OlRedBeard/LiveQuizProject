﻿using System;
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
        TcpListener listener;
        HostServer server;
        public static List<HostServer> contestants = new List<HostServer>();

        public QuizHostForm()
        {
            InitializeComponent();
            cmbIP.DataSource = Dns.GetHostEntry(SystemInformation.ComputerName).AddressList
                .Where(x => x.AddressFamily == AddressFamily.InterNetwork).ToList();
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

                // Hide the IP/Starting controls
                lblIP.Visible = true;
                cmbIP.Enabled = false;
                cmbIP.Visible = false;
                btnBegin.Enabled = false;
                btnBegin.Visible = false;
            }
            catch
            {

            }
        }
    }
}