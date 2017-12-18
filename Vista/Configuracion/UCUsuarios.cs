using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Vista.Componentes;

namespace Vista.Configuracion
{
    public partial class UCUsuarios : UserControl
    {
        public UCUsuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usuariosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBTransporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            estado(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.AddNew();
            estado(true);
        }

        private void estado(bool state)
        {
            panel8.Enabled = state;
            btnGuardar.Enabled = state;
            btnCancelar.Enabled = state;

            btnModificar.Enabled = !state;
            btnNuevo.Enabled = !state;
            btnEliminar.Enabled = !state;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar este registro?", "Eliminar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.No) return;

            usuariosBindingSource.RemoveAt(usuariosBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.CancelEdit();
            estado(false);
        }

        private void UCUsuarios_Load(object sender, EventArgs e)
        {
            usuariosTableAdapter.Fill(dBTransporte.usuarios);
            rolTableAdapter.Fill(dBTransporte.Rol);
            estado(false);
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fotoTextBox.Text = openFileDialog1.FileName;
            loadImage();
        }

        private void loadImage()
        {
            if (fotoTextBox.Text == string.Empty)
            {
                pbxPerfil.Image = null;
            }
            else
            {
                if (File.Exists(fotoTextBox.Text))
                {
                    pbxPerfil.Load(fotoTextBox.Text);
                }
                else
                {
                    pbxPerfil.Image = null;
                }
            }
        }

        private void usuariosDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            loadImage();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.leftLine(panel5);
        }
    }
}
