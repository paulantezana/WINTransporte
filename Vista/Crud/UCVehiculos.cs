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
    public partial class UCVehiculos : UserControl
    {
        public UCVehiculos()
        {
            InitializeComponent();
        }

        private void vehiculosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiculosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTransporte);
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
            vehiculosDataGridView.Visible = false;

            /*switch (usuario.rool)
            {
                case "Usuario":
                    vehiculosDataGridView.Visible = true;
                    break;
                case "Gerente":
                    vehiculosDataGridView.Visible = true;
                    break;
                case "Admin":
                    btnNuevo.Visible = true;
                    btnModificar.Visible = true;
                    btnEliminar.Visible = true;
                    btnGuardar.Visible = true;
                    btnCancelar.Visible = true;
                    vehiculosDataGridView.Visible = true;
                    break;
                case "Empresa":
                    vehiculosDataGridView.Visible = true;
                    break;
                case "Secretaria":
                    vehiculosDataGridView.Visible = true;
                    break;
                default:
                    break;
            }*/

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormImprimirVehiculo formImprimir = new FormImprimirVehiculo();
            formImprimir.ShowDialog();
        }
    }
}
