using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Componerntes;

namespace Vista.Crud
{
    public partial class UCRutas : UserControl
    {
        public UCRutas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            rutasBindingSource.AddNew();
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

            rutasBindingSource.RemoveAt(rutasBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.rutasBindingSource.CancelEdit();
            estado(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (partidaTextBox.Text == "")
            {
                errorProvider1.SetError(partidaTextBox, "El campo partida esta vacía");
                partidaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (destinoTextBox.Text == "")
            {
                errorProvider1.SetError(destinoTextBox, "El campo destino esta vacía");
                destinoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (frecuenciaTextBox.Text == "")
            {
                errorProvider1.SetError(frecuenciaTextBox, "El campo frecuencia esta vacía");
                frecuenciaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (distanciaTextBox.Text == "")
            {
                errorProvider1.SetError(distanciaTextBox, "El campo distancia esta vacía");
                distanciaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (cruce_rutaTextBox.Text == "")
            {
                errorProvider1.SetError(cruce_rutaTextBox, "El campo cruce ruta esta vacía");
                cruce_rutaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (cerradaCheckBox.Checked)
            {
                errorProvider1.SetError(cerradaCheckBox, "El campo cruce cerrada esta vacía");
                cerradaCheckBox.Focus();
                return;
            }
            errorProvider1.Clear();

            this.Validate();
            this.rutasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
            estado(false);
        }

        private void UCRutas_Load(object sender, EventArgs e)
        {
            rutasTableAdapter.Fill(dBTransporte.rutas);
            estado(false);
        }

        private void frecuenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }

        private void distanciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }
    }
}
