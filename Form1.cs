using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Kapec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServerForm ServerFormForm = new ServerForm();
            ServerFormForm.Show();
        }

        private void ConnectToSetverButton_Click(object sender, EventArgs e)
        {
            ClientForm ClientFormForm = new ClientForm();
            ClientFormForm.Show();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int y = SystemInformation.PrimaryMonitorSize.Height; //высота экрана
            int x = SystemInformation.PrimaryMonitorSize.Width; //ширина экрана
            switch (e.KeyChar)
            {
                case 'w':
                    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - 20);
                    break;

                case 's':
                    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 20);
                    break;

                case 'a':
                    Cursor.Position = new Point(Cursor.Position.X - 20, Cursor.Position.Y);
                    break;

                case 'd':
                    Cursor.Position = new Point(Cursor.Position.X + 20, Cursor.Position.Y);
                    break;
            }

        }
    }
}
