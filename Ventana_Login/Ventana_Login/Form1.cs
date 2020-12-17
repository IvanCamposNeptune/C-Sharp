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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {

            if (txtID.Text == "Admin" && txtContra.Text == "cdlc")
            {
                //MessageBox.Show("Se ha iniciado sesion correctamente");

                txtID.Text = "";//Limpia los textbox
                txtContra.Text = "";


                this.Hide();//La ventana se oculta 

                Registro VentanaReg = new Registro();//Se crea un objeto de tipo de la ventana que hemos creado

                VentanaReg.Show();//Se manda mostrar la ventana que se creo




            }
            else
            {
                MessageBox.Show("Error: ID o Contraseña incorrectos...");

                txtID.Text = "";// Limpia los textbox
                txtContra.Text = "";

                txtID.Focus();//Inicia en el txtID 
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
