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

        }
    }
}
