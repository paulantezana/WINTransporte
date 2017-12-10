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
    public partial class UCTipoEmpresa : UserControl
    {
        public UCTipoEmpresa()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(tipoTextBox.Text == "")
            {
                errorProvider1.SetError(tipoTextBox, "El campo tipo esta vacía");
                tipoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            this.Validate();
            this.tipo_empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
            estado(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tipo_empresasBindingSource.CancelEdit();
            estado(false);
        }

        private void estado(bool state)
        {
            tipoTextBox.Enabled = state;

            btnGuardar.Enabled = state;
            btnCancelar.Enabled = state;

            btnModificar.Enabled = !state;
            btnNuevo.Enabled = !state;
            btnEliminar.Enabled = !state;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo_empresasBindingSource.AddNew();
            estado(true);
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

            tipo_empresasBindingSource.RemoveAt(tipo_empresasBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
        }

        private void UCTipoEmpresa_Load(object sender, EventArgs e)
        {
            tipo_empresasTableAdapter.Fill(dBTransporte.tipo_empresas);
            estado(false);
        }
    }
}
