using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_ListBox_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //El pictrueBox 1 mostrara la imagen del texto que este seleccionado en el listBox
            // con respecto a la direccion donde esten guardadas las imagenes
            // el nombre que tenga en el listBox que tiene que ser igual al de la imagen y se concatena la extension.
            pictureBox1.ImageLocation = "C:/Users/Usuario/Pictures/" + listBox1.Text + ".jpg";


            //Lo mismo que arriba pero usando el combo box. y se mostrara en el otro pictureBox
            pictureBox2.ImageLocation = "C:/Users/Usuario/Pictures/" + comboBox1.Text + ".jpg";

            //El pictureBox para que la imagen este bien tiene que tene la propiedad de SizeMode en StretchImage.

        }
    }
}
