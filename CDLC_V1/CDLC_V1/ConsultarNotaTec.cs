using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Libreria_CDLC; //DataSet

namespace CDLC_V1
{
    public partial class ConsultarNotaTec : Consultas
    {
        public ConsultarNotaTec()
        {
            InitializeComponent();
        }

        private void ConsultarNotaTec_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("Nota_Tecnico").Tables[0]; //Nombre de la tabla que queremos que se muestre
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Folio.Text.Trim()) == false)//Si no esta vacio entonces...
            {
                try
                {
                    DataSet DS; //Crea variable tipo DataSet

                    string cmd = "Select * FROM Nota_Tecnico WHERE folio_equipo LIKE ('%" + txt_Folio.Text.Trim() + "%') "; //Instruccion SQL para mostrar todo de la tabla donde el folio del cliente se parezca a lo que tiene el TextBox

                    DS = Utilidades.Ejecutar(cmd); //Ejecuta la instruccion SQL

                    dataGridView1.DataSource = DS.Tables[0];  //Le pasa al DataGridView el resultado de la consulta
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }

            }
        }

        private void btn_Todo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDataGV("Nota_Tecnico").Tables[0]; //Nombre de la tabla que queremos que se muestre
        }
    }
}
