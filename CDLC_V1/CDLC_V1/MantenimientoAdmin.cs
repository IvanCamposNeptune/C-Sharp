using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Libreria_CDLC; //Para usar el metodo DataSet

namespace CDLC_V1
{
    public partial class MantenimientoAdmin : Mantenimiento
    {
        public MantenimientoAdmin()
        {
            InitializeComponent();
        }


        public override bool Guardar() //Metodo Guardar
        {
            if (Validar.ValidarFormulario(this, errorProvider1) == false)  //Si en la ventana en la que estoy trabajando el RrrorProvider es igual a falso (No tiene errores) entonces se guarda.
            {
                try
                {   /* En la variable se guarda la instruccion que se ejecutara en la base de datos, Hace mencion al proceso que habiamos creado en la base de datos
                donde se le pasaban los parametros que se querian guardar, aqui se le pasan los parametros de los campos de texto y esos se mandan al proceso.*/

                DateTime fecha = DateTime.Today;

                string cmd = string.Format("EXEC ActualizaAdmin '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}'", Inicio_Sesion.Codigo, txt_Folio.Text.Trim(), txt_Nombre.Text.Trim(), txt_Numero.Text.Trim(),
                        txt_Correo.Text.Trim(), txt_Colonia.Text.Trim(), txt_Parentesco.Text.Trim(), cmb_Tipo.Text.Trim(), cmb_Marca.Text.Trim(), txt_Modelo.Text.Trim(), txt_Serie.Text.Trim(), txt_Accesorio.Text.Trim(), txt_Contraseña.Text.Trim(), txt_Reporte.Text.Trim(),
                        txt_Observacion.Text.Trim(), txt_Especiales.Text.Trim(), txt_Uso.Text.Trim(),fecha,txt_Estado.Text.Trim());

                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se Ha Guardado Correctamente.");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error... " + error.Message);
                    return false;
                }
            }
            else  //Si hay errores
            {
                return false;  //Se devuelve esto para que no procese los datos a la base de datos.
            }


        }

        public override void Eliminar() //Metodo Eliminar
        {
            try
            {
                //Instruccion de eliminar que se ejecutara por el DataSet, nadamas requiere un parametro.
                string cmd = string.Format("EXEC EliminarAdmin '{0}'", txt_Folio.Text.Trim());

                Utilidades.Ejecutar(cmd); //Ejecuta la instruccion con el DataSet
                MessageBox.Show("Se Ha Eliminado Correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error... " + error.Message);
            }
        }


        public override bool ActualizaEstadoAdmi() //Metodo Guardar
        {

            try
            {   /* En la variable se guarda la instruccion que se ejecutara en la base de datos, Hace mencion al proceso que habiamos creado en la base de datos
                donde se le pasaban los parametros que se querian guardar, aqui se le pasan los parametros de los campos de texto y esos se mandan al proceso.*/

                string cmd = string.Format("EXEC ActualizaEstadoAdmi '{0}','{1}'", txt_Folio.Text.Trim(), txt_Estado.Text.Trim());

                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se Ha Guardado Correctamente.");
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error... " + error.Message);
                return false;
            }

        }


        private void txt_Folio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Numero_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Correo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Colonia_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Parentesco_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cmb_Tipo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void cmb_Marca_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Modelo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Serie_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Accesorio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Reporte_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Observacion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Especiales_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Uso_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void MantenimientoAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "Select * FROM Usuarios WHERE id_usuario=" + Inicio_Sesion.Codigo; //Consulta tipo string concatenando codigo de usuario.

            DataSet DS = Utilidades.Ejecutar(cmd); //Ejecutando la instruccion con el metodo DataSet que se creo en el .dll MiLibreria.

            lbl_IdUsu.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString(); //Se envian los datos a los campos de texto de los labels.
        }

        private void btn_Estado_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_Folio.Text)) //Comprueba si esta vacio el campo de reporte
            {
                MessageBox.Show("El Folio no puede estar vacio", "Aviso");

            }
            else if (string.IsNullOrEmpty(txt_Estado.Text)) //Comprueba si esta vacio el campo de reporte
            {
                MessageBox.Show("El Estado no puede estar vacio", "Aviso");
            }
            else
            {
                ActualizaEstadoAdmi();
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_Folio.Text = "";
            txt_Nombre.Text = "";
            txt_Numero.Text = "";
            txt_Correo.Text = "";
            txt_Colonia.Text = "";
            txt_Parentesco.Text = "";
            cmb_Tipo.Text = "";
            cmb_Marca.Text = "";
            txt_Modelo.Text = "";
            txt_Serie.Text = "";
            txt_Accesorio.Text = "";
            txt_Contraseña.Text = "";
            txt_Reporte.Text = "";
            txt_Observacion.Text = "";
            txt_Especiales.Text = "";
            txt_Uso.Text = "";
            txt_Estado.Text = "";
        }


    }
}
