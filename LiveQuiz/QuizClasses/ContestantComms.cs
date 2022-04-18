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
        public delegate void UserAddedEventHandler(Tuple<User, UserScore> details);

        public event NextQuestionEventHandler NewQuestion;
        public delegate void NextQuestionEventHandler(QuizQuestion qq);

        public event AnswerResultEventHandler AnswerResult;
        public delegate void AnswerResultEventHandler(Tuple<User, QuizAnswer, int> answer);

        public event RemoveUserEventHandler UserRemoval;
        public delegate void RemoveUserEventHandler(List<Tuple<User, UserScore>> remove);

        public event ResultsEventHandler FinalResults;
        public delegate void ResultsEventHandler(string results);

        public event GameOverEventHandler GameOver;
        public delegate void GameOverEventHandler();

        public ContestantComms(string servername)
        {
            this.serverName = servername;
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.ProgressChanged += Bgw_ProgressChanged;
            bgw.DoWork += Bgw_DoWork;
            bgw.RunWorkerAsync();
        }

        public void RemoveUser(User u)
        {
            Tuple<User, int> end = new Tuple<User, int>(u, 0);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writer.BaseStream, end);
        }

        public void SendUserInfo(User u)
        {
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writer.BaseStream, u);
        }

        public void SendAnswer(Tuple<User, QuizAnswer, int> response)
        {
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writer.BaseStream, response);
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

                        if (o is Tuple<User, UserScore>)
                        {
                            bgw.ReportProgress(0, o);
                        }
                        else if (o is QuizQuestion)
                        {
                            bgw.ReportProgress(1, o);
                        }
                        else if (o is Tuple<User, QuizAnswer, int> answer)
                        {
                            bgw.ReportProgress(2, o);
                        }
                        else if (o is int)
                        {
                            if ((int)o == 0)
                            {
                                bgw.ReportProgress(3);
                            }
                        }
                        else if (o is string)
                        {
                            bgw.ReportProgress(4, o);
                        }
                        else if (o is List<Tuple<User, UserScore>>)
                        {
                            bgw.ReportProgress(5, o);
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
            if (e.ProgressPercentage == 0)
                UserAdded((Tuple<User, UserScore>)e.UserState);

            else if (e.ProgressPercentage == 1)
                NewQuestion((QuizQuestion)e.UserState);

            else if (e.ProgressPercentage == 2)
                AnswerResult((Tuple<User, QuizAnswer, int>)e.UserState);

            else if (e.ProgressPercentage == 3)
                GameOver();

            else if (e.ProgressPercentage == 4)
                FinalResults(e.UserState.ToString());

            else if (e.ProgressPercentage == 5)
                UserRemoval((List<Tuple<User, UserScore>>)e.UserState);
        }
    }
}
