using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Libreria_CDLC;

namespace CDLC_V1
{
    public partial class Tecnico : Formulario_Base
    {
        public Tecnico()
        {
            InitializeComponent();
        }

        private void Tecnico_Load(object sender, EventArgs e)
        {
            string cmd = "Select * FROM Usuarios WHERE id_usuario=" + Inicio_Sesion.Codigo; //Consulta tipo string concatenando codigo de usuario.

            DataSet DS = Utilidades.Ejecutar(cmd); //Ejecutando la instruccion con el metodo DataSet que se creo en el .dll MiLibreria.

            lblNomAdmin.Text = DS.Tables[0].Rows[0]["nombre_usu"].ToString();
            lblUsAdmin.Text = DS.Tables[0].Rows[0]["cuenta_usu"].ToString();
            lblCodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString(); //Se envian los datos a los campos de texto de los labels.

            //Para que cargue la foto

            string url = DS.Tables[0].Rows[0]["Foto"].ToString(); //url almacena la direccion donde esta la foto en la base de datos.

            pictureBox1.Image = Image.FromFile(url); //No se puede usar image location ya que esto es un de un archivo y no de una carpeta
        }

        private void Tecnico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();

            Inicio_Sesion Inicio = new Inicio_Sesion();

            Inicio.Show();
        }

        private void btn_Contenedor_Click(object sender, EventArgs e)
        {
            this.Hide();

            ContenedorTec ConT = new ContenedorTec();

            ConT.Show();
        }
    }
}
