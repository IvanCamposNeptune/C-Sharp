using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using MiLibreria; //Para usar el metodo DataSet

namespace FactuxD
{
    public partial class VentanaAdmin : Formulario_Base
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)  //Cuando se cargue la ventana hara esto.
        {

            string cmd = "Select * FROM Usuarios WHERE id_usuario=" + VentanaLogin.Codigo; //Consulta tipo string concatenando codigo de usuario.

            DataSet DS = Utilidades.Ejecutar(cmd); //Ejecutando la instruccion con el metodo DataSet que se creo en el .dll MiLibreria.

            lblNomAdmin.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUsAdmin.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblCodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString(); //Se envian los datos a los campos de texto de los labels.

            //Para que cargue la foto

            string url = DS.Tables[0].Rows[0]["Foto"].ToString(); //url almacena la direccion donde esta la foto en la base de datos.

            pictureBox1.Image = Image.FromFile(url); //No se puede usar image location ya que esto es un de un archivo y no de una carpeta

        }


        private void button3_Click(object sender, EventArgs e)
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
