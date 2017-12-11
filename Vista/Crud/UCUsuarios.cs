using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Crud
{
    public partial class UCUsuarios : UserControl
    {
        public UCUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.AddNew();
            estado(true);
        }

        private void estado(bool state)
        {
            usuarioTextBox.Enabled = state;
            claveTextBox.Enabled = state;
            confirmarTextBox.Enabled = state;
            nombreTextBox.Enabled = state;
            emailTextBox.Enabled = state;
            fotoTextBox.Enabled = state;
            roolComboBox.Enabled = state;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (usuarioTextBox.Text == "")
            {
                errorProvider1.SetError(usuarioTextBox, "El campo usuario esta vacía");
                usuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (claveTextBox.Text == "")
            {
                errorProvider1.SetError(claveTextBox, "El campo clave esta vacía");
                claveTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (confirmarTextBox.Text != claveTextBox.Text)
            {
                errorProvider1.SetError(confirmarTextBox, "Las contraseñas no coinciden");
                confirmarTextBox.Focus();
                return;
            }
            errorProvider1.Clear();


            if (nombreTextBox.Text == "")
            {
                errorProvider1.SetError(nombreTextBox, "El campo nombre esta vacía");
                nombreTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (roolComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(roolComboBox, "El campo rool esta vacía");
                roolComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            try
            {
                this.Validate();
                this.usuariosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBTransporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Error usuario",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            estado(false);
        }

        private void UCUsuarios_Load(object sender, EventArgs e)
        {
            usuariosTableAdapter.Fill(dBTransporte.usuarios);
            estado(false);
        }
    }
}
