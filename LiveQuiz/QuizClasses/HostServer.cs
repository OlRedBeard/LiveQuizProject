using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Added using statements
using System.Net.Sockets;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuizClasses
{
    public class HostServer
    {
        public static TcpListener Listener;

        private BackgroundWorker worker = new BackgroundWorker();
        private Socket connection;
        private NetworkStream stream;
        private BinaryReader reader;
        private BinaryWriter writer;
        private bool done = false;

        public User theUser; 

        public event NewClientConnectedEventHandler NewClientConnected;
        public delegate void NewClientConnectedEventHandler(HostServer client);

        public event UserAddedEventHandler UserAdded;
        public delegate void UserAddedEventHandler(HostServer client, User u);

        public event UserAnswerEventHandler UserAnswer;
        public delegate void UserAnswerEventHandler(HostServer client, Tuple<User, QuizAnswer, int> answer);

        public event UserLeftEventHandler UserLeft;
        public delegate void UserLeftEventHandler(HostServer client, Tuple<User, int> user);

        public HostServer(TcpListener listener)
        {
            HostServer.Listener = listener;
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerAsync();
        }

        public void SendUpdate(object o)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writer.BaseStream, o);
            }
            catch
            {
                throw;
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //throw new NotImplementedException();
            try
            {
                if(e.ProgressPercentage == 0)
                {
                    NewClientConnected(this);
                }
                else if (e.ProgressPercentage == 1)
                {
                    UserAdded(this, (User)e.UserState);
                }
                else if (e.ProgressPercentage == 2)
                {
                    UserAnswer(this, (Tuple<User, QuizAnswer, int>)e.UserState);
                }
                else if (e.ProgressPercentage == 3)
                {
                    UserLeft(this, (Tuple<User, int>)e.UserState);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                connection = Listener.AcceptSocket();
                worker.ReportProgress(0);

                stream = new NetworkStream(connection);
                reader = new BinaryReader(stream);
                writer = new BinaryWriter(stream);

                while (!done)
                {
                    try
                    {
                        IFormatter formatter = new BinaryFormatter();
                        object o = (object)formatter.Deserialize(reader.BaseStream);

                        // Check what the type is
                        if (o is User)
                        {
                            worker.ReportProgress(1, o);
                        }
                        else if (o is Tuple<User, QuizAnswer, int>)
                        {
                            worker.ReportProgress(2, o);
                        }
                        else if (o is Tuple<User, int>)
                        {
                            worker.ReportProgress(3, o);
                        }
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }
        }
    }
}
