﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MiLibreria; //Para usar el DataSet

namespace FactuxD
{
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }


        public override bool Guardar() //Metodo Guardar
        {
            if (Validar.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {   /* En la variable se guarda la instruccion que se ejecutara en la base de datos, Hace mencion al proceso que habiamos creado en la base de datos
                donde se le pasaban los parametros que se querian guardar, aqui se le pasan los parametros de los campos de texto y esos se mandan al proceso.*/
                    string cmd = string.Format("EXEC ActualizaCliente '{0}','{1}','{2}'", txt_IdCli.Text.Trim(), txt_NomCli.Text.Trim(), txt_ApeCli.Text.Trim());

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
            else
            {
                return false;
            }

               
        }

        public override void Eliminar() //Metodo Eliminar
        {
            try
            {
                //Instruccion de eliminar que se ejecutara por el DataSet, nadamas requiere un parametro.
                string cmd = string.Format("EXEC EliminarClientes '{0}'", txt_IdCli.Text.Trim());

                Utilidades.Ejecutar(cmd); //Ejecuta la instruccion con el DataSet
                MessageBox.Show("Se Ha Eliminado Correctamente");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error... " + error.Message);
            }
        }

        private void txt_IdCli_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
