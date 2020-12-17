using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana_Login
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            int cont = 0;//Contador
            string seleccion;//Seleccion de tipo cadena


            if(checkBox1.Checked == true)//Si el checkBox 1 esta seleccionado suma 1 al contador.
            {
                cont++;//Agregando 1.
            }

            if (checkBox2.Checked == true)//Si el checkBox 2 esta seleccionado suma 1 al contador.
            {
                cont++;//Agregando 1.
            }


            if(radioButton1.Checked == true)//Si el radioButton 1 esta seleccionado entonces paga con tarjeta de credito.
            {
                seleccion = "Tarjeta de Credito";
            }
            else//Sino, entonces esta seleccionado el radioButton 2 y pagara con Paypal.
            {
                seleccion = "Paypal";
            }


            MessageBox.Show("Ha elegido " + cont + " cursos" + " y el metodo de pago es: " + seleccion);



        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Hide();//Oculta la ventana donde este.

            Login VentanaLogin = new Login();

            VentanaLogin.Show();

        }
    }
}
