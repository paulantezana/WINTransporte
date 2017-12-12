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
            permiso();
        }


        private void permiso()
        {
            Usuario usuario = UsuarioController.usuario;
            btnNuevo.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            tipo_empresasDataGridView.Visible = false;

            switch (usuario.rool)
            {
                case "Usuario":
                    tipo_empresasDataGridView.Visible = true;
                    estado(false);
                    break;
                case "Gerente":
                    tipo_empresasDataGridView.Visible = true;
                    estado(false);
                    break;
                case "Admin":
                    btnNuevo.Visible = true;
                    btnModificar.Visible = true;
                    btnEliminar.Visible = true;
                    btnGuardar.Visible = true;
                    btnCancelar.Visible = true;
                    tipo_empresasDataGridView.Visible = true;
                    estado(false);
                    break;
                case "Empresa":
                    break;
                case "Secretaria":
                    break;
                default:
                    break;
            }

        }
    }
}
