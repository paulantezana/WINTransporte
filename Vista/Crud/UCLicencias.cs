using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Controlador;

namespace Vista.Crud
{
    public partial class UCLicencias : UserControl
    {
        public UCLicencias()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            licenciasBindingSource.AddNew();
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

            licenciasBindingSource.RemoveAt(licenciasBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.licenciasBindingSource.CancelEdit();
            estado(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (licenciaTextBox.Text == "")
            {
                errorProvider1.SetError(licenciaTextBox, "El campo licencia esta vacía");
                licenciaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            this.Validate();
            this.licenciasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
            estado(false);
        }

        private void UCLicencias_Load(object sender, EventArgs e)
        {
            licenciasTableAdapter.Fill(dBTransporte.licencias);
            estado(false);
            // permiso();
        }

        private void permiso()
        {
            Usuario usuario = UsuarioController.usuario;
            btnNuevo.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            licenciasDataGridView.Visible = false;

           /* switch (usuario.rool)
            {
                case "Usuario":
                    licenciasDataGridView.Visible = true;
                    estado(false);
                    break;
                case "Gerente":
                    licenciasDataGridView.Visible = true;
                    estado(false);
                    break;
                case "Admin":
                    btnNuevo.Visible = true;
                    btnModificar.Visible = true;
                    btnEliminar.Visible = true;
                    btnGuardar.Visible = true;
                    btnCancelar.Visible = true;
                    licenciasDataGridView.Visible = true;
                    estado(false);
                    break;
                case "Empresa":
                    licenciasDataGridView.Visible = true;
                    estado(false);
                    break;
                case "Secretaria":
                    licenciasDataGridView.Visible = true;
                    estado(false);
                    break;
                default:
                    break;
            }*/

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormImprimirLicencias formImprimir = new FormImprimirLicencias();
            formImprimir.ShowDialog();
        }
    }
}
