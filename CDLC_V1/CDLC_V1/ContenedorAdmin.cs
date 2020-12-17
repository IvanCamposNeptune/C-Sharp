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
    public partial class ContenedorAdmin : Form
    {
        private int childFormNumber = 0;

        public ContenedorAdmin()
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

        private void ContenedorAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoAdmin ManAdmi = new MantenimientoAdmin(); //Se crea la instancia.
            ManAdmi.MdiParent = this; //Se eespecifica que pertenece al contenedor mdi para que se muestre ahi
            ManAdmi.Show(); //Se muestra.
        }

        private void administradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarAdmin ConAdm = new ConsultarAdmin();
            ConAdm.MdiParent = this;
            ConAdm.Show();

        }

        private void tecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarTec ConTec = new ConsultarTec();
            ConTec.MdiParent = this;
            ConTec.Show();
        }

        private void reporteTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarRepoTec ConRepTec = new ConsultarRepoTec();
            ConRepTec.MdiParent = this;
            ConRepTec.Show();
        }

        private void notaDeContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarNotaTec ConNotTec = new ConsultarNotaTec();
            ConNotTec.MdiParent = this;
            ConNotTec.Show();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrador adm = new Administrador();
            adm.Show();
        }

        private void consultarEstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEstadosAdmin ConEs = new ConsultarEstadosAdmin();
            ConEs.Show();
        }

        private void consultarEstadosTécnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEstadosTec ConEst = new ConsultarEstadosTec();
            ConEst.Show();
        }
    }
}
