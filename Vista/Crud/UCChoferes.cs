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
    public partial class UCChoferes : UserControl
    {
        public UCChoferes()
        {
            InitializeComponent();
        }

        private void choferesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            choferesBindingSource.AddNew();
            estado(true);
        }

        private void estado(bool state)
        {
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

            choferesBindingSource.RemoveAt(choferesBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.choferesBindingSource.CancelEdit();
            estado(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.choferesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
            estado(false);
        }

        private void UCChoferes_Load(object sender, EventArgs e)
        {
            choferesTableAdapter.Fill(dBTransporte.choferes);
            licenciasTableAdapter.Fill(dBTransporte.licencias);
            empresasTableAdapter.Fill(dBTransporte.empresas);
        }
    }
}
