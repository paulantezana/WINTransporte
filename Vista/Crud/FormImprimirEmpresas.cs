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
    public partial class FormImprimirEmpresas : Form
    {
        public FormImprimirEmpresas()
        {
            InitializeComponent();
        }

        private void FormImprimirEmpresas_Load(object sender, EventArgs e)
        {
            CREmpresas cREmpresas = new CREmpresas();
            DBTransporte dBTransporte = new DBTransporte();
            EmpresasTableAdapter adapter = new EmpresasTableAdapter();

            adapter.Fill(dBTransporte.empresas);
            cREmpresas.SetDataSource(dBTransporte);
            crystalReportViewer1.ReportSource = cREmpresas;
        }
    }
}
