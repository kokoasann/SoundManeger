using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;

namespace SoundManeger
{
    public partial class Form1 : Form
    {
        private System.Media.SoundPlayer soundPlayer = null;
        private WaveStream wstream;
        private int playInd =0;
        private bool isPlay = false;

        private List<string> pathList = new List<string>();
        //public List<string> pathList
        //{
        //    get
        //    {
        //        return pathList;
        //    }
        //    set
        //    {
        //        pathList = value;
        //    }
        //}

        private TimeSpan time = new TimeSpan();
        private NAudio.Wave.WaveFileReader wfr = null;

        public setting Xset
        {
            get;
            set;
        }

        public Form1()
        {
            InitializeComponent();
            xmlLoad();
            xset2favslist();

            pathList = new List<string>();
            if(Xset == null)
                Xset = new setting();
            if (Xset.filters == null) 
                Xset.filters = new Filters();
            if(Xset.filters.fil == null)
                Xset.filters.fil = new List<Filter>();

            FavsCheckListBox.ContextMenuStrip = FCLBMenuStrip;
            //Xset.filters = new Filters();
            //Xset.filters.fil = new List<Filter>();
            //Xset.filters.fil.Add(new Filter());
            //Xset.filters.fil[0].filterName = "test";
            //Xset.filters.fil[0].fav = new List<string>();
            //Xset.filters.fil[0].fav.Add("aaa");
            //xmlSave();
        }

        //xmlのデータをfavslistに入れる
        public void xset2favslist()
        {
            FavsCheckListBox.Items.Clear();
            foreach (var fs in Xset.filters.fil)
            {
                FavsCheckListBox.Items.Add(fs.filterName,false);
            }
        }

        private void xmlLoad()
        {
            System.IO.FileStream FO = new System.IO.FileStream(@"setting.xml", System.IO.FileMode.Open);
            System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(setting));
            Xset = (setting)xs.Deserialize(FO);
            FO.Close();
        }

        private void xmlSave()
        {


            using(System.IO.FileStream FW = new System.IO.FileStream(@"setting.xml", System.IO.FileMode.Create))
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(FW, Encoding.UTF8))
                {
                    System.Xml.Serialization.XmlSerializerNamespaces xsn = new System.Xml.Serialization.XmlSerializerNamespaces();
                    xsn.Add(string.Empty, string.Empty);
                    System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer(typeof(setting));
                    xs.Serialize(sw, Xset);

                    sw.Flush();
                }
            }

        }

        //ファイルのパスをファイル名だけにする
        public string path2fname(string path)
        {
            string fn = path.Substring(path.LastIndexOf("\\") + 1);
            return fn;
        }

        //ドラッグ＆ドロップ
        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        //ドラッグ＆ドロップ
        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(var path in fileName)
            {
                if (path.EndsWith("wav") || path.EndsWith("WAV"))
                {
                    pathList.Add(path);
                    string fn = path2fname(path);
                    listBox1.Items.Add(fn);
                }
            }
            //listBox1.Items.AddRange(fileName);
            while (listBox1.Items.Count > 4096)
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i == -1)
                i = 0;
            playInd = i;
            Play(playInd);
            listBox1.Focus();
        }

        private void Play(int i)
        {
            listBox1.SelectedItem = listBox1.Items[i];
            //string path = listBox1.Items[i].ToString();
            string path = pathList[i];
            wstream = new WaveStream(System.IO.File.OpenRead(path));
            wstream.Volume = volumeBar.Value;
            using (soundPlayer = new System.Media.SoundPlayer(wstream))
            {
                //soundPlayer = new System.Media.SoundPlayer(path);
                soundPlayer.Play();
                //soundPlayer.PlaySync();

                isPlay = true;

                wfr = new NAudio.Wave.WaveFileReader(path);
                time = wfr.TotalTime;
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Stop();
            listBox1.Focus();
        }

        private void Stop()
        {
            if (soundPlayer == null)
                return;
            soundPlayer.Stop();
            soundPlayer.Dispose();
            soundPlayer = null;

            wstream.Close();

            isPlay = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isPlay)
            {
                time -= new TimeSpan(0, 0, 0, 0, 100);
                if (time.Milliseconds < 0)
                {
                    playInd++;
                    if (playInd == listBox1.Items.Count)
                    {
                        Stop();
                        return;
                    }
                    wstream.Close();
                    Play(playInd);
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Keys)e.KeyChar == Keys.Space)
            {
                Stop();
            }
            if (this.ActiveControl == FavsNameTextBox)
                if ((Keys)e.KeyChar == Keys.Enter)
                    FavsAdd();
        }

        private void ACButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void volumeBar_ValueChanged(object sender, EventArgs e)
        {
            //wstream.Volume = volumeBar.Value;
        }

        //お気に入りのコンフィグを開く
        private void FavlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FavConfigDialog fcd = new FavConfigDialog(this);
            fcd.ShowDialog();
            xmlSave();
            
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
                NameTextBox.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
        }

        //ファイルのリネーム
        private void NameUpdateButton_Click(object sender, EventArgs e)
        {
            string oldpath = pathList[listBox1.SelectedIndex];
            string path = oldpath.Remove(oldpath.LastIndexOf("\\") + 1);
            path += NameTextBox.Text;
            listBox1.Items[listBox1.SelectedIndex] = NameTextBox.Text;
            System.IO.File.Move(oldpath, path);
        }

        private void FavsAdd()
        {
            if (FavsNameTextBox.Text == "" || FavsNameTextBox.Text == " " || FavsNameTextBox.Text == "　")
                return;

            FavsCheckListBox.Items.Add(FavsNameTextBox.Text, false);

            Filter filter = new Filter();
            filter.filterName = FavsNameTextBox.Text;
            Xset.filters.fil.Add(filter);
            Xset.filters.fil[Xset.filters.fil.Count - 1].fav = new List<string>();

            FavsNameTextBox.Text = "";
        }
        private void FavsAddButton_Click(object sender, EventArgs e)
        {
            FavsAdd();
        }

        private void FavAddButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            for(int i = 0;i < FavsCheckListBox.Items.Count;i++)
            {
                if(FavsCheckListBox.GetItemChecked(i))
                {
                    Xset.filters.fil[i].fav.Add(pathList[listBox1.SelectedIndex]);
                }
            }
        }

        //選択したフィルターをプレイリストに表示する
        private void SelFilDispItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pathList.Clear();

            for(int i = 0;i < FavsCheckListBox.Items.Count;i++)
            {
                if(FavsCheckListBox.GetItemChecked(i))
                {
                    foreach (var f in Xset.filters.fil[i].fav)
                    {
                        pathList.Add(f);
                        string fname = path2fname(f);
                        listBox1.Items.Add(fname);
                    }
                }
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            xmlSave();
        }
    }
}
