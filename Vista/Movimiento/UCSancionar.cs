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
    public partial class UCSancionar : UserControl
    {
        public UCSancionar()
        {
            InitializeComponent();
        }

        private void sancionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sancionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBTransporte);

        }

        private void UCSancionar_Load(object sender, EventArgs e)
        {
            choferesTableAdapter.Fill(dBTransporte.choferes);
            papeletasTableAdapter.Fill(dBTransporte.papeletas);
            cargarSanciones();
        }
        private void cargarSanciones()
        {
            sancionesTableAdapter.Fill(dBTransporte.Sanciones);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sancionesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBTransporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sancionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
