using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;

namespace vlc_t
{
    public partial class Form1 : Form
    {
        private string _path;
        PlayerForm _form;
        public Form1()
        {
            InitializeComponent();
            _form = new PlayerForm(_path);
            //vlcControl1.Play(new Uri("http://download.blender.org/peach/bigbuckbunny_movies/big_buck_bunny_480p_surround-fix.avi"));
        }
        /*
        private void vlcControl_VlcLibDirectoryNeeded(object sender, VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vlcControl1.Play(new Uri("http://cms.safe-tvigil.com/mediastorage/5cf00194a091e1.76284585.mp4"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (button3.Text == "Pause")
            //{
            //    vlcControl1.Pause();
            //    button3.Text = "Play";
            //}
            //else if (button3.Text == "Play")
            //{
            //    vlcControl1.Pause();
            //    button3.Text = "Pause";
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //vlcControl1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Filter = "MP4 File|*.mp4| All File|*.*" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _path = openFileDialog.FileName;
                PlayerForm f = new PlayerForm(_path);
                f.Show();

                //PlayerForm.Open(videoPath);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://www.fiverr.com/nugzars");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            _form.PlayAction(new Uri(_path));
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            _form.PauseAction();
        }

        private void StartBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
