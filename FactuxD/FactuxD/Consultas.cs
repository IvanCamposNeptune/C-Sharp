using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MiLibreria;//Para poder ejecutar un DataSet

namespace FactuxD
{
    public partial class Consultas : Formulario_Base
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public DataSet LLenarDataGV(string tabla)
        {
            DataSet DS;

            string cmd = string.Format("SELECT * FROM " + tabla);

            DS = Utilidades.Ejecutar(cmd);

            return DS;

        }


        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0) //Si no hay nada que seleccionar retorna nada.
            {
                return;
            }
            else //De lo contrario
            {
                DialogResult = DialogResult.OK; //Para comparar si el dialog result si esta en ok hacer una operacion.
                Close();
            }
        }


    }
}
