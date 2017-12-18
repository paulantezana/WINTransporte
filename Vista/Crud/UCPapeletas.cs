using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Componentes;
using Entidad;
using Controlador;

namespace Vista.Crud
{
    public partial class UCPapeletas : UserControl
    {
        public UCPapeletas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            papeletasBindingSource.AddNew();
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

            papeletasBindingSource.RemoveAt(papeletasBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.papeletasBindingSource.CancelEdit();
            estado(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == "")
            {
                errorProvider1.SetError(nombreTextBox, "El campo nombre esta vacía");
                nombreTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (tipoComboBox.Text == "")
            {
                errorProvider1.SetError(nombreTextBox, "El campo tipo esta vacía");
                nombreTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            this.Validate();
            this.papeletasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
            estado(false);
        }

        private void UCPapeletas_Load(object sender, EventArgs e)
        {
            papeletasTableAdapter.Fill(dBTransporte.papeletas);
            estado(false);
           // permiso();
        }

        private void montoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validator.isNumber(e);
        }
        private void permiso()
        {
            Usuario usuario = UsuarioController.usuario;
            btnNuevo.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            papeletasDataGridView.Visible = false;

            /*switch (usuario.rool)
            {
                case "Usuario":
                    papeletasDataGridView.Visible = true;
                    estado(false);
                    break;
                case "Gerente":
                    papeletasDataGridView.Visible = true;
                    estado(false);
                    break;
                case "Admin":
                    btnNuevo.Visible = true;
                    btnModificar.Visible = true;
                    btnEliminar.Visible = true;
                    btnGuardar.Visible = true;
                    btnCancelar.Visible = true;
                    papeletasDataGridView.Visible = true;
                    estado(false);
                    break;
                case "Empresa":
                    papeletasDataGridView.Visible = true;
                    estado(false);
                    break;
                case "Secretaria":
                    papeletasDataGridView.Visible = true;
                    estado(false);
                    break;
                default:
                    break;
            }*/

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormImprimirPapeletas formImprimir = new FormImprimirPapeletas();
            formImprimir.ShowDialog();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FormImportarPapeletas formImportar = new FormImportarPapeletas();
            formImportar.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.leftLine(panel5);
        }
    }
}
