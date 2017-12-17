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
    public partial class FormImprimirPapeletas : Form
    {
        public FormImprimirPapeletas()
        {
            InitializeComponent();
        }

        private void FormImprimirPapeletas_Load(object sender, EventArgs e)
        {
            CRPapeletas cRPapeletas = new CRPapeletas();
            DBTransporte dBTransporte = new DBTransporte();
            PapeletasTableAdapter adapter = new PapeletasTableAdapter();

            adapter.Fill(dBTransporte.papeletas);
            cRPapeletas.SetDataSource(dBTransporte);
            crystalReportViewer1.ReportSource = cRPapeletas;
        }
    }
}
