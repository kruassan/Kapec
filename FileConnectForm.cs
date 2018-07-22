using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Kapec
{
    public delegate void GetingThisQWE(string[] peredacha);

    public delegate void GettingTreeView(byte[] xypma);

    public delegate void GettingTreeNode(byte[] content, string xmde);

    public partial class FileConnectForm : Form
    {
        //штука для перекидывания в комбобокс
        public static GetingThisQWE tet;

        public static GettingTreeView GetTreeView1;

        public static GettingTreeNode GetterTreeNode;

        string[] TekushiyeNazvaniya;

        public FileConnectForm()
        {
            //присвоение делегата методу заполнения комбобокс
            tet = new GetingThisQWE(ZapolnitcomboBox);

            GetTreeView1 = new GettingTreeView(CreateNewSpisokFilesFromByte);

            InitializeComponent();
        }

        //начальное заполнение моего treeview
        private void ComboboxOfMyComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDirectTree.Nodes.Clear();
            string SelectedOne = (Convert.ToString(ComboboxOfMyComp.SelectedItem));
            MyDirectTree.Nodes.Add(SelectedOne);

            try
            {
                string[] kekekek1 = Directory.GetDirectories(SelectedOne);

                //тут будет хуйня конкретно для начального заполнения директорий
                for (int w = 0; w < kekekek1.Length; w++)
                {
                    MyDirectTree.Nodes[0].Nodes.Add(Path.GetFileName(kekekek1[w]));

                    try
                    {
                        string[] kekekek2 = Directory.GetDirectories(kekekek1[w]);

                        for (int w1 = 0; w1 < kekekek2.Length; w1++)
                        {
                            MyDirectTree.Nodes[0].Nodes[w].Nodes.Add(Path.GetFileName(kekekek2[w1]));
                        }
                    }
                    catch
                    { }
                }

                string[] kykykyk1 = Directory.GetFiles(SelectedOne);

                //тут будет хуйня конкрутно для начального заполнения файлов
                for (int w = 0; w < kykykyk1.Length; w++)
                {
                    MyDirectTree.Nodes[0].Nodes.Add(Path.GetFileName(kykykyk1[w]));

                    try
                    {
                        string[] kykykyky2 = Directory.GetFiles(kykykyk1[w]);

                        for (int w1 = 0; w1 < kykykyky2.Length; w1++)
                        {
                            MyDirectTree.Nodes[0].Nodes[w].Nodes.Add(Path.GetFileName(kykykyky2[w1]));
                        }
                    }
                    catch
                    { }
                }
            }
            catch
            {
                //устройство не готово
            }

        }


        //хуйня
        private void TreeMakeWithRecursion(TreeViewCancelEventArgs kek1)
        {
            try
            {
                string[] kekekek1 = Directory.GetDirectories(kek1.Node.FullPath);

                for (int w = 0; w < kekekek1.Length; w++)
                {
                    try
                    {
                        string[] kekekek2 = Directory.GetDirectories(kek1.Node.Nodes[w].FullPath);


                        for (int w1 = 0; w1 < kekekek2.Length; w1++)
                        {
                            try
                            {
                                string[] kekekeke3 = Directory.GetDirectories(kek1.Node.Nodes[w].Nodes[w1].FullPath);

                                string[] Failoviykekekeke3 = Directory.GetFiles(kek1.Node.Nodes[w].Nodes[w1].FullPath);
                                for (int w3 = 0; w3 < kekekeke3.Length; w3++)
                                { kek1.Node.Nodes[w].Nodes[w1].Nodes.Add(Path.GetFileName(kekekeke3[w3])); }
                                for (int FW = 0; FW < Failoviykekekeke3.Length; FW++)
                                { kek1.Node.Nodes[w].Nodes[w1].Nodes.Add(Path.GetFileName(Failoviykekekeke3[FW])); }
                            }
                            catch { }
                        }
                    }
                    catch
                    { }
                }
            }
            catch
            {


            }

        }

        private void MyDirectTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeMakeWithRecursion(e);
        }

        private void MyDirectTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                MyListBox.Items.Add(MyDirectTree.SelectedNode.FullPath);
            }
            catch
            { }
        }


        private void OtherListBoxClear_Click(object sender, EventArgs e)
        {
            OtherListBox.Items.Clear();
        }

        private void MyListBoxClear_Click(object sender, EventArgs e)
        {
            MyListBox.Items.Clear();
        }

        private void MyDelete_Click(object sender, EventArgs e)
        {
            //File.Delete(MyDirectTree.SelectedNode.FullPath);
            if (Path.GetExtension(MyDirectTree.SelectedNode.FullPath) == "")
            {
                try
                {
                    Directory.Delete(MyDirectTree.SelectedNode.FullPath, true);
                    MyDirectTree.SelectedNode.Remove();
                }
                catch
                {
                    //если не удалось удалить папку
                }
            }
            else
            {
                try
                {
                    File.Delete(MyDirectTree.SelectedNode.FullPath);
                    MyDirectTree.SelectedNode.Remove();
                }
                catch
                {
                    //если не удалось удалить файл
                }
            }
        }

        private void ComboboxOfMyComp_MouseClick(object sender, MouseEventArgs e)
        {
            string[] StartDitectories = Environment.GetLogicalDrives();

            ComboboxOfMyComp.Items.Clear();

            foreach (string s in StartDitectories)
            {
                ComboboxOfMyComp.Items.Add(s);
            }
        }

        private void ComboboxOfOtherComp_MouseClick(object sender, MouseEventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("#D");
            ServerForm.client.Send(msg);
        }

        public void ZapolnitcomboBox(string[] xenon)
        {
            ComboboxOfOtherComp.Items.Clear();
            foreach (string s in xenon)
            {
                ComboboxOfOtherComp.Items.Add(s);
            }
        }

        private void OtherStartDirectLoad_Click(object sender, EventArgs e)
        {
            if (ComboboxOfOtherComp.Text.Length != 0)
            {
                byte[] msg = Encoding.UTF8.GetBytes("#T[" + ComboboxOfOtherComp.Text + "]");
                ServerForm.client.Send(msg);
            }
        }

        private void OtherCompDirectBox_DoubleClick(object sender, EventArgs e)
        {
            int x = 0;

            foreach (ListViewItem item in OtherCompDirectBox.SelectedItems)
            {
                x = item.Index;
            }

            if (TekushiyeNazvaniya[x].Substring(TekushiyeNazvaniya[x].Length -1, 1) != "s")
            {
                byte[] msg = Encoding.UTF8.GetBytes("#T[" + TekushiyeNazvaniya[x].Substring(0, TekushiyeNazvaniya[x].Length - 1) + "]");
                ServerForm.client.Send(msg);
            }
        }

        public void CreateNewSpisokFilesFromByte(byte[] content)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(content, 0, content.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            string[] obj = (string[])binForm.Deserialize(memStream);

            try
            {
                OtherFullDirectPole.Text = Path.GetDirectoryName(obj.First().Substring(0, obj.First().Length - 1));

                OtherCompDirectBox.Items.Clear();

                TekushiyeNazvaniya = obj;

                for (int w = 0; w < TekushiyeNazvaniya.Length; w++)
                {
                    ListViewItem xxx = new ListViewItem();
                    xxx.Text = (Path.GetFileName(TekushiyeNazvaniya[w].Substring(0, TekushiyeNazvaniya[w].Length - 1)));
                    string sravn = Path.GetExtension(TekushiyeNazvaniya[w].Substring(0, TekushiyeNazvaniya[w].Length - 1));
                    if (TekushiyeNazvaniya[w].Substring(TekushiyeNazvaniya[w].Length -1,1) == "s")
                    {
                        if ((sravn == ".bmp") || (sravn == ".gif") || (sravn == ".jpeg") || (sravn == ".jpg") || (sravn == ".png") || (sravn == ".jpe") || (sravn == ".pdf") || (sravn == ".BMP") || (sravn == ".GIF") || (sravn == ".JPEG") || (sravn == ".JPG") || (sravn == ".PNG") || (sravn == ".JPE") || (sravn == ".PDF"))
                        {
                            xxx.ImageKey = "ImageIcon.png";
                        }
                        else
                        {
                            if ((sravn == ".mp4") || (sravn == ".avi") || (sravn == ".HDrip") || (sravn == ".flv") || (sravn == ".mpeg") || (sravn == ".MP4") || (sravn == ".AVI") || (sravn == ".FLV") || (sravn == ".MPEG"))
                            {
                                xxx.ImageKey = "VideoIcon.png";
                            }
                            else
                            {
                                if (sravn == ".exe")//(() || () || () || () || () || () || () || () || () || () || () || () || () || () || () || () ||)
                                {
                                    xxx.ImageKey = "EXEIcon.png";
                                }
                                else
                                {
                                    if ((sravn == ".txt") || (sravn == ".odt") || (sravn == ".doc") || (sravn == ".docx") || (sravn == ".docm") || (sravn == ".TXT") || (sravn == ".ODT") || (sravn == ".DOC") || (sravn == ".DOCX") || (sravn == ".DOCM"))
                                    {
                                        xxx.ImageKey = "TextIcon.png";
                                    }
                                    else
                                    {
                                        xxx.ImageKey = "FileIcon.png";
                                    }

                                }
                            }
                        }
                    }
                    if (TekushiyeNazvaniya[w].Substring(TekushiyeNazvaniya[w].Length - 1, 1) == "d")
                    {
                        xxx.ImageKey = "PapkaIcon.png";
                    }
                    OtherCompDirectBox.Items.Add(xxx);
                    //OtherCompDirectBox.Items.Add(Path.GetFileName(TekushiyeNazvaniya[w].Substring(0, TekushiyeNazvaniya[w].Length - 1)));
                    //OtherCompDirectBox.Items[w].ImageList = ;//Properties.Resources.AudioIcon;
                }
            }
            catch
            { }
        }

        private void GoZagruzitDirect_Click(object sender, EventArgs e)
        {
            byte[] msg = Encoding.UTF8.GetBytes("#T[" + OtherFullDirectPole.Text + "]");
            ServerForm.client.Send(msg);
        }

        private void GoNazadDirect_Click(object sender, EventArgs e)
        {
            OtherFullDirectPole.Text = Path.GetDirectoryName(OtherFullDirectPole.Text);
            GoZagruzitDirect_Click(sender,e);
        }
    }
}
