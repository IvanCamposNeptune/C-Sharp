using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDLC_V1
{
    public partial class ContenedorTec : Form
    {
        private int childFormNumber = 0;

        public ContenedorTec()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ContenedorTec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoTec ManTec = new MantenimientoTec(); //Se crea la instancia.
            ManTec.MdiParent = this; //Se eespecifica que pertenece al contenedor mdi para que se muestre ahi
            ManTec.Show(); //Se muestra.
        }

        private void tecnicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarTec ConTec = new ConsultarTec(); //Se crea la instancia.
            ConTec.MdiParent = this; //Se eespecifica que pertenece al contenedor mdi para que se muestre ahi
            ConTec.Show(); //Se muestra.
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarRepoTec ConRepTec = new ConsultarRepoTec(); //Se crea la instancia.
            ConRepTec.MdiParent = this; //Se eespecifica que pertenece al contenedor mdi para que se muestre ahi
            ConRepTec.Show(); //Se muestra.
        }

        private void notasDeContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarNotaTec ConNotTec = new ConsultarNotaTec(); //Se crea la instancia.
            ConNotTec.MdiParent = this; //Se eespecifica que pertenece al contenedor mdi para que se muestre ahi
            ConNotTec.Show(); //Se muestra.
        }

        private void informacionDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacionTec InfoTec = new InformacionTec(); //Se crea la instancia.
            InfoTec.MdiParent = this; //Se eespecifica que pertenece al contenedor mdi para que se muestre ahi
            InfoTec.Show(); //Se muestra.
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tecnico tec = new Tecnico();
            tec.Show();
        }

        private void estadosDeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEstadosTec ConEst = new ConsultarEstadosTec();
            ConEst.Show();
        }
    }
}
