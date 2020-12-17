using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MiLibreria; //Para usar el metodo DataSet

namespace FactuxD
{
    public partial class VentanaUser : Formulario_Base
    {
        public VentanaUser()
        {
            InitializeComponent();
        }

        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaUser_Load(object sender, EventArgs e)
        {

            string cmd = "Select * FROM Usuarios WHERE id_usuario=" + VentanaLogin.Codigo; //Consulta tipo string concatenando codigo de usuario.

            DataSet DS = Utilidades.Ejecutar(cmd); //Ejecutando la instruccion con el metodo DataSet que se creo en el .dll MiLibreria.

            lblNombUs.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUs.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblCodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString(); //Se envian los datos a los campos de texto de los labels.

            //Para que cargue la foto

            string url = DS.Tables[0].Rows[0]["Foto"].ToString(); //url almacena la direccion donde esta la foto en la base de datos.

            pictureBox1.Image = Image.FromFile(url); //No se puede usar image location ya que esto es un de un archivo y no de una carpeta.


        }


        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaLogin Ventana = new VentanaLogin();

            Ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ContenedorPrincipal ConP = new ContenedorPrincipal();
            ConP.Show();
        }
    }
}
