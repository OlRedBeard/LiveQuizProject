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

        public HostServer(TcpListener listener)
        {
            HostServer.Listener = listener;
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerAsync();
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
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
                        if (o is QuizAnswer)
                        {

                        }
                        else
                        {

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
