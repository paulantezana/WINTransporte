using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.DBTransporteTableAdapters;

namespace Vista.Crud
{
    public partial class FormImprimirRutas : Form
    {
        public FormImprimirRutas()
        {
            InitializeComponent();
        }

        private void FormImprimirRutas_Load(object sender, EventArgs e)
        {
            CRRutas cRRutas = new CRRutas();
            DBTransporte dBTransporte = new DBTransporte();
            RutasTableAdapter adapter = new RutasTableAdapter();

            adapter.Fill(dBTransporte.rutas);
            cRRutas.SetDataSource(dBTransporte);
            crystalReportViewer1.ReportSource = cRRutas;
        }
    }
}
