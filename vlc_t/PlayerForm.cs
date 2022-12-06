using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vlc_t
{
    public partial class PlayerForm : Form
    {
        string _path;

        private void PlayerForm_Load(object sender, EventArgs e)
        {

            vlcControl1.Play(new Uri(_path));
            var a = vlcControl1.Time;
            //new Uri(@"C:\Users\zuraz\OneDrive\Desktop\Projects\123.mp4"));
            //restart
            //vlcControl1.();
        }

        public PlayerForm(string path)
        {
            InitializeComponent();
            _path = path;
        }

        public void PlayAction(Uri uri)
        {
            _path = uri.AbsolutePath;
            var thread2 = new System.Threading.Thread(WriteTextUnsafe);
            thread2.Start();
        }

        private void WriteTextUnsafe()
        {
            PlayerForm f = new PlayerForm(_path);
            f.Show();
        }



        public void PauseAction()
        {
            vlcControl1.Pause();
        }

        public void StopAction()
        {
            vlcControl1.Stop();
        }



    }
}
