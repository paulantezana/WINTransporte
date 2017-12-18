using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Movimiento
{
    public partial class UCAutorizar : UserControl
    {
        public UCAutorizar()
        {
            InitializeComponent();
        }

        private void autorizacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void UCAutorizar_Load(object sender, EventArgs e)
        {
            autorizacionesTableAdapter.Fill(dBTransporte.Autorizaciones);
            rutasTableAdapter.Fill(dBTransporte.rutas);
            empresasTableAdapter.Fill(dBTransporte.empresas);

            choferesTableAdapter.Fill(dBTransporte.choferes);
            vehiculosTableAdapter.Fill(dBTransporte.vehiculos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.autorizacionesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBTransporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sancionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            autorizacionesBindingSource.AddNew();
            fechaDateTimePicker.Value = DateTime.Now;
            estado(true);
        }

        private void estado(bool v)
        {
            // return tru
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.autorizacionesBindingSource.CancelEdit();
            estado(false);
        }
    }
}
