using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kapec
{
    public delegate void Thread4Listener();

    public partial class ClientForm : Form
    {
        bool PrinyatFile = false;
        bool FileStarted = false;

        string ReNameRash = "xxx.docx";

        byte[] b = new byte[0];

        string[] ujebilo = new string[0];

        private NetworkStream Stream4StreamClient;
        private TcpClient StreamClienter1 = new TcpClient();

        private Thread4Listener T4L;
        private Threads1 _myThreads;

        private Thread kurwaldio2;

        private Thread kurwaldio3;

        public ClientForm()
        {
            InitializeComponent();
            ipText.Text = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
        }


        Socket Sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        Socket Sender2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


        public void RunnerListen()
        {
            byte[] bytes = new byte[1024];

            int bytesRec = Sender.Receive(bytes);

            string KurwasAdd = String.Format(Encoding.UTF8.GetString(bytes, 0, bytesRec));

            string KurwasAdd2 = "";

            if (KurwasAdd.Length > 1)
            {
                KurwasAdd2 = KurwasAdd.Substring(0, 2);

                if (KurwasAdd2 == "M[")
                {
                    infoPole.Items.Add(KurwasAdd);
                    //Cursor.Position = new Point(Convert.ToInt32(Math.Round(SystemInformation.PrimaryMonitorSize.Width * Convert.ToDouble(KurwasAdd.Substring(2, KurwasAdd.LastIndexOf("|") - 2)))), Convert.ToInt32(Math.Round(SystemInformation.PrimaryMonitorSize.Height * Convert.ToDouble(KurwasAdd.Substring(KurwasAdd.LastIndexOf("|") + 1, KurwasAdd.LastIndexOf("]") - KurwasAdd.LastIndexOf("|") - 1)))));
                }
                else
                {
                    if (KurwasAdd2 == "C[")
                    {

                        infoPole.Items.Add(KurwasAdd);
                        //Cursor.Position = new Point(Convert.ToInt32(Math.Round(SystemInformation.PrimaryMonitorSize.Width * Convert.ToDouble(KurwasAdd.Substring(2, KurwasAdd.LastIndexOf("|") - 2)))), Convert.ToInt32(Math.Round(SystemInformation.PrimaryMonitorSize.Height * Convert.ToDouble(KurwasAdd.Substring(KurwasAdd.LastIndexOf("|") + 1, KurwasAdd.LastIndexOf("]") - KurwasAdd.LastIndexOf("|") - 1)))));
                    }
                    else
                    {
                        if (KurwasAdd2 == "#T")
                        {
                            byte[] msg = Encoding.UTF8.GetBytes("#T--");
                            Sender2.Send(msg);

                            string[] GetDitectories = new string[1];

                            try
                            {
                                GetDitectories = Directory.GetDirectories(KurwasAdd.Substring(3, KurwasAdd.IndexOf("]") - 3));
                                for(int w = 0; w< GetDitectories.Length; w++)
                                {
                                    GetDitectories[w] = GetDitectories[w] + "d";
                                }
                                string[] GetFiles = Directory.GetFiles(KurwasAdd.Substring(3, KurwasAdd.IndexOf("]") - 3));
                                for (int w = 0; w < GetFiles.Length; w++)
                                {
                                    GetFiles[w] = GetFiles[w] + "s";
                                }

                                int GD = GetDitectories.Length;
                                Array.Resize(ref GetDitectories, GetDitectories.Length + GetFiles.Length);
                                for (int w = 0; w < GetFiles.Length; w++)
                                {
                                    GetDitectories[GD + w] = GetFiles[w];
                                }
                                foreach (string s in GetDitectories)
                                {
                                    infoPole.Items.Add(s);
                                }
                            }
                            catch
                            {
                                GetDitectories = new string[1];
                                GetDitectories[0] = "Disk is not ready-";
                            }

                            MemoryStream fs = new MemoryStream();
                            BinaryFormatter sf = new BinaryFormatter();
                            sf.Serialize(fs, GetDitectories);
                            byte[] PosrednikOfSerialize = new byte[fs.Length];
                            PosrednikOfSerialize = fs.ToArray();

                            Sender2.Send(PosrednikOfSerialize);
                        }
                        else
                        {
                            if (KurwasAdd2 == "#D")
                            {
                                string[] StartDitectories = Environment.GetLogicalDrives();
                                string StringOfStartDirect = "";
                                foreach (string s in StartDitectories)
                                { StringOfStartDirect = StringOfStartDirect + s + "-"; }
                                StringOfStartDirect = StringOfStartDirect.Remove(StringOfStartDirect.Length - 1, 1);

                                byte[] msg = Encoding.UTF8.GetBytes("#D" + StringOfStartDirect);

                                Sender.Send(msg);

                            }
                            else
                            {
                                infoPole.Items.Add(KurwasAdd);
                            }
                        }
                    }
                }
            }
            else
            {
                infoPole.Items.Add(KurwasAdd);
            }

        }

        public void RunListenFilesTV()
        {
            while (true)
            {
                if (PrinyatFile == false)
                {
                    byte[] bytes = new byte[1024];

                    int bytesRec = Sender2.Receive(bytes);

                    string KurwasAdd = String.Format(Encoding.UTF8.GetString(bytes, 0, bytesRec));

                    string KurwasAdd2 = "";
                    if (KurwasAdd.Length > 2)
                    { KurwasAdd2 = KurwasAdd.Substring(0, 2); }

                    if (KurwasAdd2 == "#S")
                    {
                        PrinyatFile = true;
                        FileStarted = true;
                        infoPole.Items.Add("Start translation");

                        ReNameRash = KurwasAdd.Substring(3, KurwasAdd.IndexOf("]") - 3);
                    }
                }
                else
                {
                    int bytesRec1 = 0;

                    byte[] bytes = new byte[999999999];

                    if (Sender2.Available != 0)
                    {
                        bytesRec1 = Sender2.Receive(bytes);
                    }
                    else
                    {
                        Thread.Sleep(200);

                        if (Sender2.Available != 0)
                        {
                            bytesRec1 = Sender2.Receive(bytes);
                        }
                        else
                        {
                            FileStarted = false;
                        }

                    }

                    if (FileStarted == true)
                    {
                        infoPole.Items.Add(bytesRec1);
                        Array.Resize(ref bytes, bytesRec1);
                        Array.Resize(ref b, b.Length + bytesRec1);
                        bytes.CopyTo(b, b.Length - bytesRec1);
                    }

                    if (FileStarted == false)
                    {
                        File.WriteAllBytes("D:\\PomoikaSiSharp\\" + ReNameRash, b);

                        Array.Resize(ref b, 0);
                        PrinyatFile = false;
                        infoPole.Items.Add("End translation");
                    }
                }
            }
        }

        public void ObrabotchikOfSockets()
        {
            //просмотр, для кого, зачем, и пр по первым 3 байтам
            //удаление первых 3 байт соответственно
            //обработка, пересылка куда нужно. Может для этого создать отдельные методы

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if ((portText.Text != portText2.Text) && (portText.Text != AAAaKAk6OMBIT.Text) && (portText2.Text != AAAaKAk6OMBIT.Text) && (portText.Text.Length > 0) && (portText2.Text.Length > 0) && (AAAaKAk6OMBIT.Text.Length > 0))//StreamClienter2
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ipText.Text), Convert.ToInt32(portText.Text));

                IPEndPoint ipStreamEndpoint = new IPEndPoint(IPAddress.Parse(ipText.Text), Convert.ToInt32(portText2.Text));

                IPEndPoint ipFilaAndTVEndpoint = new IPEndPoint(IPAddress.Parse(ipText.Text), Convert.ToInt32(AAAaKAk6OMBIT.Text));

                try
                {
                    // Соединяем сокет с удаленной точкой
                    Sender.Connect(ipEndPoint);

                    StreamClienter1.Connect(ipStreamEndpoint);

                    Sender2.Connect(ipFilaAndTVEndpoint);

                    //возня с тредом c чатом 

                    T4L = new Thread4Listener(RunnerListen);
                    _myThreads = new Threads1(T4L);
                    _myThreads.RunThreads();
                    Control.CheckForIllegalCrossThreadCalls = false;
                    //возня с тредом по стриму
                    kurwaldio2 = new Thread(StreamFromClient);

                    kurwaldio2.IsBackground = true;
                    kurwaldio2.Start();
                    //Возня с тредом с файлами

                    kurwaldio3 = new Thread(RunListenFilesTV);

                    kurwaldio3.IsBackground = true;
                    kurwaldio3.Start();
                }
                catch { infoPole.Items.Add("Connection failed"); }
            }
            else
            { infoPole.Items.Add("Please, write 2 differing ports"); }

        }

        public void StreamFromClient()
        {
            while (true)
            {
                BinaryFormatter binFormatter = new BinaryFormatter();
                Stream4StreamClient = StreamClienter1.GetStream();
                binFormatter.Serialize(Stream4StreamClient, kek());
            }

        }

        private static Image kek()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            Graphics gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(0, 0, 0, 0, new Size(bmp.Width, bmp.Height));
            return bmp;
        }


        private void SendButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte[] msg = Encoding.UTF8.GetBytes(RTB2.Text);

                Sender.Send(msg);
            }
            catch { infoPole.Items.Add("Messaging failed, check your connection status"); }
        }

        private void SendFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (RashNamePole.Text.Length != 0)
                {
                    byte[] msg = Encoding.UTF8.GetBytes("#S[" + RashNamePole.Text + "]");
                    Sender2.Send(msg);
                }
                else
                {
                    byte[] msg = Encoding.UTF8.GetBytes("#S[" + Path.GetFileName(dialog.FileName) + "]");
                    Sender2.Send(msg);
                }

                byte[] a = File.ReadAllBytes(dialog.FileName);
                Sender2.Send(a);
            }
        }
    }
}
