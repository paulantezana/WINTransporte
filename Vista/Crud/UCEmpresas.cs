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
    public partial class UCEmpresas : UserControl
    {
        public UCEmpresas()
        {
            InitializeComponent();
        }

        private void empresasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTransporte);

        }

        private void empresasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTransporte);

        }

        private void UCEmpresas_Load(object sender, EventArgs e)
        {
            tipo_empresasTableAdapter.Fill(dBTransporte.tipo_empresas);
            empresasTableAdapter.Fill(dBTransporte.empresas);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            empresasBindingSource.AddNew();
            estado(true);
        }

        private void estado(bool state)
        {
            codigoTextBox.Enabled = state;
            nombreTextBox.Enabled = state;
            propietarioTextBox.Enabled = state;
            gerenteTextBox.Enabled = state;
            telefonoTextBox.Enabled = state;
            direccionTextBox.Enabled = state;
            ciudadTextBox.Enabled = state;
            id_tipo_empresaComboBox.Enabled = state;

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

            empresasBindingSource.RemoveAt(empresasBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.empresasBindingSource.CancelEdit();
            estado(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*if (tipoTextBox.Text == "")
            {
                errorProvider1.SetError(tipoTextBox, "El campo tipo esta vacía");
                tipoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();*/

            this.Validate();
            this.empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
            estado(false);
        }

        private void empresasBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTransporte);

        }
    }
}
