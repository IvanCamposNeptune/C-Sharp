using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;//Para las palabras reservadas de data
using System.Data.SqlClient;//Para las palabras reservadas de SqlClient

using System.Windows.Forms; //Para poder usar las palabras reservadas de un Form

namespace MiLibreria
{
    public class Utilidades //Se le da el nombre de utilidades 
    {
        public static DataSet Ejecutar(string cmd) //Metodo DataSet
        {

            SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True"); //Conexion a la base de datos local

            Conexion.Open(); //Abriendo la conexion a la base de datos

            DataSet DS = new DataSet(); //Creando una variable de tipo DataSet

            SqlDataAdapter DP = new SqlDataAdapter(cmd, Conexion); //Adapta los datos de la base (comando, a la conexion)

            DP.Fill(DS); //Rellena el SqlDataAdapter con los datos del DataSet

            Conexion.Close(); //Se cierra la conexion para evitar errores

            return DS; //Regresa el valor del DataSet

        }

    }


//Apartado para llenar los ComboBox

    public class Conexion
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;


        public Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
                cnn.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se conecto..." + error.Message);
            }
        }


        public void llenarItems(ComboBox cb)
        {

            try
            {
                cmd = new SqlCommand("Select Nom_usu from Usuarios", cnn);

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr["Nom_usu"].ToString());
                }

                dr.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show("No se lleno el ComboBox" + error.Message);
            }

        }


    }

}
