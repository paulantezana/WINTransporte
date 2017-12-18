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
using Vista.Componentes;

namespace Vista.Crud
{
    public partial class UCVehiculos : UserControl
    {
        UsuarioController usuarioController = new UsuarioController();
        Usuario usuario = UsuarioController.usuario;

        public UCVehiculos()
        {
            InitializeComponent();
        }

        private void vehiculosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vehiculosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBTransporte);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sancionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void permiso()
        {
            Usuario usuario = UsuarioController.usuario;
            btnNuevo.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;
            vehiculosDataGridView.Visible = false;
            panelControls.Visible = false;

            if (usuarioController.puedeEliminar(usuario.idRool, "vehiculos"))
            {
                btnEliminar.Visible = true;
            }
            if (usuarioController.puedeEditar(usuario.idRool, "vehiculos"))
            {
                btnModificar.Visible = true;
                btnNuevo.Visible = true;
                btnGuardar.Visible = true;
                btnCancelar.Visible = true;
                panelControls.Visible = true;
            }
            if (usuarioController.puedeConsultar(usuario.idRool, "vehiculos"))
            {
                vehiculosDataGridView.Visible = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormImprimirVehiculo formImprimir = new FormImprimirVehiculo();
            formImprimir.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.leftLine(panel5);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vehiculosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBTransporte);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sancionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void UCVehiculos_Load(object sender, EventArgs e)
        {
            permiso();
        }
    }
}
