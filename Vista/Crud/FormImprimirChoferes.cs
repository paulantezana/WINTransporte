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
    public partial class FormImprimirChoferes : Form
    {
        public FormImprimirChoferes()
        {
            InitializeComponent();
        }

        private void FormImprimirChoferes_Load(object sender, EventArgs e)
        {
            CRChoferes cRChoferes = new CRChoferes();
            DBTransporte dBTransporte = new DBTransporte();
            ChoferesTableAdapter adapter = new ChoferesTableAdapter();

            adapter.Fill(dBTransporte.choferes);
            cRChoferes.SetDataSource(dBTransporte);
            crystalReportViewer1.ReportSource = cRChoferes;
        }
    }
}
