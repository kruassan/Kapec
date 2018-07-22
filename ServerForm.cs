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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Messaging;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kapec
{
    public delegate void Thread4ServerListener();

    //public delegate void OtFileConnectForm(); // wat?
    
    public partial class ServerForm : Form
    {
        private static GetingThisQWE tetatet;     
        
        private static GettingTreeView tet_GTV;

        private NetworkStream Stream4StreamServer;
        private TcpListener StreamListenerServer;
        private TcpClient StreamClientServer;
        
        private Thread4ServerListener T4SL;
        
        private Threads2 _myThreads1;

        private Thread KurwaldoiThread;
        private Thread KurwaldoiThread2;

        //Массивы для текста и файлов
        byte[] a;

        byte[] b = new byte[0];

        string PriemType = "";
                

        bool PrinyatFile = false;
        bool FileStarted = false;

        string ReNameRash = "xxx.docx";


        public ServerForm()
        {
            InitializeComponent();

            string IP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            ipText.Text = (IP);
            
        }
        //Обьявление сокетов
        public static Socket client;

        public static Socket client2;   

        public void ReceiveCallback(IAsyncResult AsyncCall)
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                Byte[] message = encoding.GetBytes("You connected to server");

                client = (Socket)AsyncCall.AsyncState;
                client = client.EndAccept(AsyncCall);

                client.Send(message);

               T4SL = new Thread4ServerListener(RunListenPort);
               _myThreads1 = new Threads2(T4SL);
               _myThreads1.RunServerThreads();
               Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void ReceiveCallback4Stream(IAsyncResult AsyncCall)
        {
            StreamClientServer = new TcpClient();
            StreamClientServer = StreamListenerServer.EndAcceptTcpClient(AsyncCall);
            
            KurwaldoiThread = new Thread(kurwaldio);
            KurwaldoiThread.IsBackground = true;
            KurwaldoiThread.Start();
        }

        public void ReciveCallBack4TVandF(IAsyncResult AsyncCall)
        {
            client2 = (Socket)AsyncCall.AsyncState;
            client2 = client2.EndAccept(AsyncCall);


            KurwaldoiThread2 = new Thread(RunListenFiles);
            KurwaldoiThread2.IsBackground = true;
            KurwaldoiThread2.Start();
        }



        private void CreateButton_Click_1(object sender, EventArgs e)
        {
            if ((portText.Text != StreamPortText.Text) && (portText.Text != FandTVPortText.Text) && (StreamPortText.Text != FandTVPortText.Text) && (portText.Text.Length > 0) && (StreamPortText.Text.Length > 0) && (FandTVPortText.Text.Length > 0))
            {
                try
                {
                    //хуйня для чата
                    Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    
                    IPEndPoint ipEndpoint = new IPEndPoint(IPAddress.Parse(ipText.Text), Convert.ToInt32(portText.Text));

                    listenSocket.Bind(ipEndpoint);

                    listenSocket.Listen(10);

                    listenSocket.BeginAccept(new AsyncCallback(ReceiveCallback), listenSocket);
                    
                    //хуйня для файлов и treeview
                    Socket listenSocket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    IPEndPoint ipEndpoint2 = new IPEndPoint(IPAddress.Parse(ipText.Text), Convert.ToInt32(FandTVPortText.Text));

                    listenSocket2.Bind(ipEndpoint2);

                    listenSocket2.Listen(10);

                    listenSocket2.BeginAccept(new AsyncCallback(ReciveCallBack4TVandF), listenSocket2);

                    infoPole.Items.Add("In process...");


                    Control.CheckForIllegalCrossThreadCalls = false;

                    //аналогичная хуйня TcpListener
                    StreamListenerServer = new TcpListener(new IPEndPoint(IPAddress.Parse(ipText.Text), Convert.ToInt32(StreamPortText.Text)));
                    StreamListenerServer.AllowNatTraversal(true);
                    StreamListenerServer.Start();
                    StreamListenerServer.BeginAcceptTcpClient(ReceiveCallback4Stream, StreamListenerServer);
                }
                catch
                { infoPole.Items.Add("Port creating failed"); }
            }
            else
            { infoPole.Items.Add("Please, write 2 differing ports"); }
        }       

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                Byte[] message = encoding.GetBytes(textBox1.Text);

                client.Send(message);
            }
            catch
            { infoPole.Items.Add("Messaging failed, check your connection status"); }
        }

        public void kurwaldio()
        {
            while (true)
              {
                if (StreamChB.Checked)
                {
                    BinaryFormatter binFormatter = new BinaryFormatter();
                    Stream4StreamServer = StreamClientServer.GetStream();
                    PB1.Image = (Image)binFormatter.Deserialize(Stream4StreamServer);
                }
            }
        }

        //чатик
        public void RunListenPort()
        {
            byte[] bytes = new byte[1024];

            int bytesRec1 = client.Receive(bytes);

            string Adder = String.Format(Encoding.UTF8.GetString(bytes, 0, bytesRec1));

            if (Adder.Length >1)
            {
                string SubAdder = Adder.Substring(0, 2);
                if (SubAdder == "#D")
                {
                    string[] SubSubAdder = Adder.Substring(2, Adder.Length - 2).Split(Convert.ToChar("-"));
                    foreach (string keker in SubSubAdder)
                    {
                        RTB1.AppendText(keker + "_");
                    }

                    FileConnectForm.tet(SubSubAdder);

                }
                else
                {
                    infoPole.Items.Add(Adder);
                }
            }
            else
            {
                infoPole.Items.Add(Adder);
            }
        }       

        public void RunListenFiles()
        {
            while (true)
            {
                if (PrinyatFile == false)
                {
                    byte[] bytes = new byte[999999999];

                    int bytesRec1 = client2.Receive(bytes);

                    string Adder = String.Format(Encoding.UTF8.GetString(bytes, 0, bytesRec1));

                    if (Adder.Length > 3)
                    {
                        if (Adder.Substring(0, 2) == "#S")
                        {
                            FileStarted = true;
                            PrinyatFile = true;
                            PriemType = "File";
                            infoPole.Items.Add("Start translation");

                            if (Adder.Substring(2, 1) == "[")
                            {
                                ReNameRash = Adder.Substring(3, Adder.IndexOf("]") - 3);
                            }
                        }
                        else
                        {
                            if (Adder.Substring(0, 2) == "#T")
                            {
                                FileStarted = true;
                                PrinyatFile = true;
                                PriemType = "SpisokOfDirect";
                                infoPole.Items.Add("Start translation");
                            }
                            else
                            {
                                if (Adder.Substring(0, 2) == "#N")
                                {
                                    FileStarted = true;
                                    PrinyatFile = true;
                                    PriemType = "TreeNode";
                                    infoPole.Items.Add("Start translation");

                                    if (Adder.Substring(2, 1) == "[")
                                    {
                                        ReNameRash = Adder.Substring(3, Adder.IndexOf("]") - 3);
                                    }
                                }

                            }
                        }
                    }
                }
                else
                {
                    int bytesRec1 = 0;

                    byte[] bytes = new byte[1024];

                    if (client2.Available != 0)
                    {
                        bytesRec1 = client2.Receive(bytes);
                    }
                    else
                    {
                        Thread.Sleep(200);

                        if (client2.Available != 0)
                        {
                            bytesRec1 = client2.Receive(bytes);
                        }
                        else
                        {
                            FileStarted = false;
                        }

                    }

                    if (FileStarted == true)
                    {
                        Array.Resize(ref bytes, bytesRec1);
                        Array.Resize(ref b, b.Length + bytesRec1);
                        bytes.CopyTo(b, b.Length - bytesRec1);
                    }

                    if (FileStarted == false)
                    {
                        if (PriemType == "File")
                        {
                            File.WriteAllBytes("D:\\PomoikaSiSharp\\" + ReNameRash, b);

                            Array.Resize(ref b, 0);
                            PrinyatFile = false;
                            infoPole.Items.Add("End translation");
                        }

                        if (PriemType == "SpisokOfDirect")
                        {
                            //переслать с помощью делегата в treeView
                            FileConnectForm.GetTreeView1(b);

                            Array.Resize(ref b, 0);
                            PrinyatFile = false;
                            infoPole.Items.Add("End translation");
                        }
                    }
                }
            }

        }
            
        //Просмотреть код файла, потом ликвидировать
        private void SendButton01_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                 a = File.ReadAllBytes(dialog.FileName);
                 for (int i = 0; i<a.Length; i++)               
                 {
                    RTB1.AppendText(Convert.ToString(a[i] + " "));
                 }
            }
        }

        private void PB1_MouseMove_1(object sender, MouseEventArgs e)
        {
                if (CheckCursorGo.Checked == true)
                {
                    textBox2.Text = Convert.ToString(e.Location.X); textBox5.Text = Convert.ToString(Math.Round((Convert.ToDouble(e.Location.X) / Convert.ToDouble(PB1.Size.Width)), 2));
                    textBox3.Text = Convert.ToString(e.Location.Y); textBox4.Text = Convert.ToString(Math.Round((Convert.ToDouble(e.Location.Y) / Convert.ToDouble(PB1.Size.Height)), 2));

                    string SendMouseMover = String.Format("M[" + textBox5.Text + "|" + textBox4.Text + "]");

                    ASCIIEncoding encoding = new ASCIIEncoding();
                    Byte[] message = encoding.GetBytes(SendMouseMover);

                    client.Send(message);
                    Thread.Sleep(50);
                }
        }

        private void FilesConnectButton_Click(object sender, EventArgs e)
        {

            FileConnectForm FileConnectForm1 = new FileConnectForm();
            FileConnectForm1.Show();
            
        }

        private void PB1_MouseClick(object sender, MouseEventArgs e)
        {
            if (CheckCursorClick.Checked)
            {
                string SendMouseMover = String.Format("C[" + Convert.ToString(Math.Round((Convert.ToDouble(e.Location.X) / Convert.ToDouble(PB1.Size.Width)), 2)) + "|" + Convert.ToString(Math.Round((Convert.ToDouble(e.Location.Y) / Convert.ToDouble(PB1.Size.Height)), 2)) + "]");

                ASCIIEncoding encoding = new ASCIIEncoding();
                Byte[] message = encoding.GetBytes(SendMouseMover);

                client.Send(message);
            }
        }

        private void SendAfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog1 = new OpenFileDialog();
            if (dialog1.ShowDialog() == DialogResult.OK)
            {
                if (RashNamePole.Text.Length != 0)
                {
                    byte[] msg = Encoding.UTF8.GetBytes("#S[" + RashNamePole.Text + "]");
                    client2.Send(msg);
                }
                else
                {
                    byte[] msg = Encoding.UTF8.GetBytes("#S[" + Path.GetFileName(dialog1.FileName) + "]");
                    client2.Send(msg);
                }

                byte[] KP9I= File.ReadAllBytes(dialog1.FileName);
                client2.Send(KP9I);
            }
        }
    }
}
                    