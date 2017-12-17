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
    public partial class FormImprimirLicencias : Form
    {
        public FormImprimirLicencias()
        {
            InitializeComponent();
        }

        private void FormImprimirLicencias_Load(object sender, EventArgs e)
        {
            CRLicencias cRLicencias = new CRLicencias();
            DBTransporte dBTransporte = new DBTransporte();
            LicenciasTableAdapter adapter = new LicenciasTableAdapter();

            adapter.Fill(dBTransporte.licencias);
            cRLicencias.SetDataSource(dBTransporte);
            crystalReportViewer1.ReportSource = cRLicencias;
        }
    }
}
