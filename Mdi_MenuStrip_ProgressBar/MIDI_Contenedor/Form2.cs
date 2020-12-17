using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIDI_Contenedor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            progressBar1.Minimum = 1;//Tamaño minimo
            progressBar1.Maximum = 100;//Tamaño maximo
            progressBar1.Step = 2;// Pasos que da

            for (int x=0; x<100; x++)//Hasta que llegue a 100
            {
                progressBar1.PerformStep();//Va incrementando esto, 
            }





        }
    }
}
