using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Reportes
{
    public partial class UCRChoferes : UserControl
    {
        public UCRChoferes()
        {
            InitializeComponent();
        }

        private void UCRChoferes_Load(object sender, EventArgs e)
        {
            empresasTableAdapter.Fill(dBTransporte.empresas);
        }
    }
}
