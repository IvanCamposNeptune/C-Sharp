using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactuxD
{
    public partial class Formulario_Base : Form
    {
        public Formulario_Base()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            // Si, muestra mensaje preguntando, sera de tipo aviso, tendra botones de si y no, tendra icono de pregunta, el boton que estara por default sera el 1. si eso es igual yes entonces sale.
            if(MessageBox.Show("¿Desea Salir?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes )
            {
                this.Close();
            }
        }


        public virtual void Eliminar()
        {

        }

        public virtual void Nuevo()
        {

        }

        public virtual void Consultar()
        {

        }

        public virtual Boolean Guardar()
        {

            return false;
        }







        private void Formulario_Base_Load(object sender, EventArgs e)
        {

        }
    }
}
