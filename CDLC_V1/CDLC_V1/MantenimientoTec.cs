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
    public partial class MantenimientoTec : Mantenimiento
    {
        public MantenimientoTec()
        {
            InitializeComponent();
        }

        private void Tecnico_Load(object sender, EventArgs e)
        {
            string cmd = "select * FROM Usuarios WHERE id_usuario=" + Inicio_Sesion.Codigo; //Consulta tipo string, le concatena el id_usuario 

            DataSet DS = Utilidades.Ejecutar(cmd); //Ejecuta la instruccion con el metodo DataSet creado en el .dll Libreria_CDLC.

            lbl_IdUsu.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString(); //Envia al texto del label el nombre del usuario que se logueo.
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_Folio.Text)) //Comprueba si esta vacio el campo de reporte
            {
                MessageBox.Show("El Folio no puede estar vacio", "Aviso");

            }
            else if(string.IsNullOrEmpty(txt_Reporte.Text)) //Comprueba si esta vacio el campo de reporte
            {
                    MessageBox.Show("El reporte no puede estar vacio", "Aviso");
            }
            else
            {
                GuardarReporte();
            }

        }

        private void btn_Contacto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Folio.Text)) //Comprueba si esta vacio el campo de reporte
            {
                MessageBox.Show("El Folio no puede estar vacio", "Aviso");
            }
            else if (string.IsNullOrEmpty(txt_Contacto.Text)) //Comprueba si esta vacio el campo de reporte
            {
                MessageBox.Show("La Nota no puede estar vacia", "Aviso");
            }
            else
            {
                GuardarContacto();
            }

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
                ActualizaEstadoTec();
            }

        }



        //Definicion


        public override bool Guardar() //Metodo Guardar
        {

            if (Validar.ValidarFormulario(this, errorProvider1) == false)  //Si en la ventana en la que estoy trabajando el RrrorProvider es igual a falso (No tiene errores) entonces se guarda.
            {
                try
                {   /* En la variable se guarda la instruccion que se ejecutara en la base de datos, Hace mencion al proceso que habiamos creado en la base de datos
                donde se le pasaban los parametros que se querian guardar, aqui se le pasan los parametros de los campos de texto y esos se mandan al proceso.*/

                    DateTime fecha = DateTime.Today;

                    string cmd = string.Format("EXEC ActualizaTec '{0}','{1}','{2}','{3}','{4}','{5}'", Inicio_Sesion.Codigo, txt_Folio.Text.Trim(), txt_Servicio.Text.Trim(), txt_Presupuesto.Text.Trim(), fecha, txt_Estado.Text.Trim());

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
                string cmd = string.Format("EXEC EliminarTec '{0}'", txt_Folio.Text.Trim());

                Utilidades.Ejecutar(cmd); //Ejecuta la instruccion con el DataSet
                MessageBox.Show("Se Ha Eliminado Correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error... " + error.Message);
            }
        }

        public override bool GuardarReporte() //Metodo Guardar
        {

                try
                {   /* En la variable se guarda la instruccion que se ejecutara en la base de datos, Hace mencion al proceso que habiamos creado en la base de datos
                donde se le pasaban los parametros que se querian guardar, aqui se le pasan los parametros de los campos de texto y esos se mandan al proceso.*/

                    DateTime fecha = DateTime.Today;

                    string cmd = string.Format("EXEC ActualizaRepo '{0}','{1}','{2}','{3}'", Inicio_Sesion.Codigo, txt_Folio.Text.Trim(), txt_Reporte.Text.Trim(), fecha);

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

        public override bool GuardarContacto() //Metodo Guardar
        {

                try
                {   /* En la variable se guarda la instruccion que se ejecutara en la base de datos, Hace mencion al proceso que habiamos creado en la base de datos
                donde se le pasaban los parametros que se querian guardar, aqui se le pasan los parametros de los campos de texto y esos se mandan al proceso.*/

                    DateTime fecha = DateTime.Today;

                    string cmd = string.Format("EXEC ActualizaConta '{0}','{1}','{2}','{3}'", Inicio_Sesion.Codigo, txt_Folio.Text.Trim(), txt_Contacto.Text.Trim(), fecha);

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

        public override bool ActualizaEstadoTec() //Metodo Guardar
        {

            try
            {   /* En la variable se guarda la instruccion que se ejecutara en la base de datos, Hace mencion al proceso que habiamos creado en la base de datos
                donde se le pasaban los parametros que se querian guardar, aqui se le pasan los parametros de los campos de texto y esos se mandan al proceso.*/

                string cmd = string.Format("EXEC ActualizaEstadoTec '{0}','{1}'", txt_Folio.Text.Trim(), txt_Estado.Text.Trim());

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

        private void txt_Servicio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Presupuesto_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txt_Estado_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_Folio.Text = "";
            txt_Servicio.Text = "";
            txt_Presupuesto.Text = "";
            txt_Estado.Text = "";
            txt_Reporte.Text = "";
            txt_Contacto.Text = "";
        }


    }
}
