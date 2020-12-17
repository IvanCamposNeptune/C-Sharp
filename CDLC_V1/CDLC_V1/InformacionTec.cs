using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Libreria_CDLC; //Para el DataSet

namespace CDLC_V1
{
    public partial class InformacionTec : Consultas
    {
        public InformacionTec()
        {
            InitializeComponent();
        }

        public DataSet LLenarDataGVTec(string tabla)
        {
            DataSet DS;

            string cmd = string.Format("SELECT folio_cliente, nombre_cliente, numero_cliente, tipo_equipo, marca_equipo, modelo_equipo, serie_equipo, accesorio_equipo, contraseña_equipo, reporte_equipo, observaciones_equipo, especiales_equipo, uso_equipo, fecha_entrada, estado_equipo FROM " + tabla);

            DS = Utilidades.Ejecutar(cmd);

            return DS;

        }

        private void InformacionTec_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGVTec("Administrador").Tables[0]; //Nombre de la tabla que queremos que se muestre
        }

        private void btn_Todo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGVTec("Administrador").Tables[0]; //Nombre de la tabla que queremos que se muestre
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Folio.Text.Trim()) == false)//Si no esta vacio entonces...
            {
                try
                {
                    DataSet DS; //Crea variable tipo DataSet

                    string cmd = "SELECT folio_cliente, nombre_cliente, numero_cliente, tipo_equipo, marca_equipo, modelo_equipo, serie_equipo, accesorio_equipo, contraseña_equipo, reporte_equipo, observaciones_equipo, especiales_equipo, uso_equipo, fecha_entrada, estado_equipo FROM Administrador WHERE folio_cliente LIKE ('%" + txt_Folio.Text.Trim() + "%') "; //Instruccion SQL para mostrar todo de la tabla donde el folio del cliente se parezca a lo que tiene el TextBox

                    DS = Utilidades.Ejecutar(cmd); //Ejecuta la instruccion SQL

                    dataGridView1.DataSource = DS.Tables[0];  //Le pasa al DataGridView el resultado de la consulta
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }

            }
        }
    }
}
