using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;


namespace QuizClasses
{
    public class ContestantComms
    {
        public string serverName;
        public int port = 5000;

        private TcpClient client;
        private NetworkStream nStream;
        private BinaryReader reader;
        private BinaryWriter writer;
        private BackgroundWorker bgw = new BackgroundWorker();

        public event ConnectedEventHandler Connected;
        public delegate void ConnectedEventHandler(string servername, int port);

        public event ConnectionFailedEventHandler ConnectionFailed;
        public delegate void ConnectionFailedEventHandler(string servername, int port);

        public event UserAddedEventHandler UserAdded;
        public delegate void UserAddedEventHandler(User u);

        public ContestantComms(string servername)
        {
            this.serverName = servername;
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.ProgressChanged += Bgw_ProgressChanged;
            bgw.DoWork += Bgw_DoWork;
            bgw.RunWorkerAsync();
        }

        public void SendUserInfo(User u)
        {
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writer.BaseStream, u);
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(this.serverName, this.port);
                nStream = client.GetStream();
                reader = new BinaryReader(nStream);
                writer = new BinaryWriter(nStream);

                Connected(this.serverName, this.port);

                try
                {
                    while (true)
                    {
                        IFormatter formatter = new BinaryFormatter();
                        object o = (object)formatter.Deserialize(nStream);

                        if (o is User)
                        {
                            bgw.ReportProgress(0, o);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                ConnectionFailed(this.serverName, this.port);
            }
        }

        private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage == 0)
            {
                UserAdded((User)e.UserState);
            }
        }
    }
}
