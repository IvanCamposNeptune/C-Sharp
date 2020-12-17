using System;
using WMPLib;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_Audio_Video
{
    public partial class Practica_Reproductor : Form
    {
        public Practica_Reproductor()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

        OpenFileDialog:
        OpenFileDialog Abrir = new OpenFileDialog();

            Abrir.Title = "Abrir";

            Abrir.ShowDialog();

            axWindowsMediaPlayer1.URL = Abrir.FileName;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
