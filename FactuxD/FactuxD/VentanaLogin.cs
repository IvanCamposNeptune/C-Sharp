using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; //Aqui ya esta incluido el Data
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; //Con este espacio de nombre se pueden hacer las conexiones a la base de datos.

using MiLibreria; // .dll creado con el nombre de clase Utilidades y un metodo llamado Ejecutar que recibe de parametro una cadena y ejecuta esa instruccion en la conexion a la base de datos

namespace FactuxD
{
    public partial class VentanaLogin : Formulario_Base
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static string Codigo = "";  //Variable publica modificable sincronizada a la cual se puede acceder de cualquier formulario. Se utilizara para saber quien se logueo.


        private void button1_Click(object sender, EventArgs e)
        {

            try // Intenta realizar este bloque de codigo
            {

                //Consulta a realizar para obtener account y password de la base de datos, obtiene lo de txt_Account.Text.Trim() y lo sustituye en account='{0}' y lo mismo con txt_Password.Text.Trim() en password='{1}'
                string CMD = string.Format("Select * FROM Usuarios WHERE account='{0}' AND password='{1}'" , txt_Account.Text.Trim() , txt_Password.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD); //Ejecuta la instruccion en la base de datos, la conexion se hizo con la clase y el metodo del .dll que creamos.

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim(); //Se guarda en la variable global Codigo para acceder al usuario que se logueo.

                //Se almacena en la variable tipo string lo que tiene el DataSet en la tabla 0 linea 0 lo que tenga en account y lo convierte a string, trim() es para juntar todo por si hay espacios. Lo mismo con password.
                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();


                //En caso de que no encontrara similitud se ejecuta el catch es por eso que esta validacion es innecesaria. A menos que se quiera hacer una comparacion de tipo de usuario (Administrador/Usuario).
                if (cuenta == txt_Account.Text.Trim() && contra == txt_Password.Text.Trim())
                  {

                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["tipo_admin"]) == true) //Convierte a boleano lo que contenga el DataSet y compara si es verdadero.
                    {
                        //En caso de que sea True, el usuario es tipo administrador

                        this.Hide(); //Se oculta la ventana actual

                        VentanaAdmin Admin = new VentanaAdmin(); //Se crea una variable de tipo del fromulario al que queramos ir.

                        Admin.Show(); //Y se muestra el tipo de formulario de la variable que creamos

                    }
                    else
                    {
                        //Si no, es usuario

                        this.Hide(); //Se oculta la ventana actual

                        VentanaUser User = new VentanaUser(); //Se crea una variable de tipo del fromulario al que queramos ir.

                        User.Show(); //Y se muestra el tipo de formulario de la variable que creamos


                    }

                }
                  


            }
            catch(Exception error) //En caso de algun error se crea una variable de error que muestra el error.
            {
                MessageBox.Show("Account o Password incorrectos..." + error.Message);

                txt_Account.Text = "";
                txt_Password.Text = "";

                txt_Account.Focus();

            }



        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

            Conexion c = new Conexion();
            c.llenarItems(txt_Account);

        }
    }
}
