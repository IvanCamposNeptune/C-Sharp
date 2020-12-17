using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; //Para espacios de nombre Data
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;// Con este espacio de nombre se accede a las funciones sql

using Libreria_CDLC; // .dll creado con el nombre de clase Utilidades y un metodo llamado Ejecutar que recibe de parametro una cadena y ejecuta esa instruccion en la conexion a la base de datos



namespace CDLC_V1
{
    public partial class Inicio_Sesion : Formulario_Base  //Clase tipo Form llamada Inicio_Sesion Heredando de la clase Form
    {
        public Inicio_Sesion()//Constructor
        {
            InitializeComponent();//Metodo de inicializacion de componentes
        }

        public static string Codigo = ""; //Variable global que almacenara el codigo del usuario que se loguee.

        private void btn_Iniciar_Click(object sender, EventArgs e)//Programacion del boton Iniciar
        {

            //Usuarios en lista del ComboBox

            /* Configuracion del ComboBox
                Para que el comboBox funcione bien tiene que configurarse en sus propiedades 
                AutoCompleteMode en Suggest    ---- Modo de autocompletado sugerido
                AutocompleteSource en ListItems    ---- Busqueda de autocompletado en la lista de 
            */

            try // Intenta realizar este bloque de codigo
            {
                //Consulta a realizar para obtener cuenta_usu y contra_usu de la base de datos, obtiene lo de comboBox.Text.Trim() y lo sustituye en cuenta_usu='{0}' y lo mismo con txt_Contra.Text.Trim() en contra_usu='{1}'
                string CMD = string.Format("Select * FROM Usuarios WHERE cuenta_usu='{0}' AND contra_usu='{1}'", comboBox.Text.Trim(), txt_Contra.Text.Trim());

                //Ejecuta la instrucción en la base de datos, la conexión se hizo con la clase y el método del .dll que creamos.
                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim(); //Almacena el id_usuario del usuario que se logueo.

                //Se almacena en la variable tipo string lo que tiene el DataSet en la tabla 0 linea 0 lo que tenga en cuenta_usu y lo convierte a string, trim() es para juntar todo por si hay espacios. Lo mismo con contra_usu.
                string cuenta = ds.Tables[0].Rows[0]["cuenta_usu"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["contra_usu"].ToString().Trim();

                if (cuenta == comboBox.Text.Trim() && contra == txt_Contra.Text.Trim()) //Esta validacion es inecesaria ya que si no hubiera semejanzas entraria directamente al catch, pero por si acaso.
                {

                    if ( Convert.ToBoolean(ds.Tables[0].Rows[0]["tipo_admin"]) == true ) //Convierte a boleano lo que contenga el DataSet y compara si es verdadero.
                    {
                        //En caso de que sea True, el usuario es tipo administrador

                        this.Hide(); //Se oculta la ventana actual

                        Administrador Admin = new Administrador(); //Se crea una variable de tipo del fromulario al que queramos ir.

                        Admin.Show(); //Y se muestra el tipo de formulario de la variable que creamos

                    }
                    else
                    {
                        //Si no, es usuario

                        this.Hide(); //Se oculta la ventana actual

                        Tecnico Tec = new Tecnico(); //Se crea una variable de tipo del fromulario al que queramos ir.

                        Tec.Show(); //Y se muestra el tipo de formulario de la variable que creamos


                    }


                }


            }
            catch (Exception) //En caso de algun error se crea una variable de error que muestra el error.
            {
                MessageBox.Show("Cuenta o Contraseña incorrectas...");
                comboBox.Text = "";
                txt_Contra.Text = "";
                comboBox.Focus();

            }

        }



        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();//Cerrar programa
        }



        private void Inicio_Sesion_FormClosed(object sender, FormClosedEventArgs e)//Este evento es de cuando se sale del form
        {
            Application.Exit(); //Para que cierre correctamente la aplicacion al momento de salir
        }

        private void Inicio_Sesion_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.llenarItems(comboBox);
        }
    }
}
