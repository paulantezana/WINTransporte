using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Reportes;

namespace Vista.Navegacion
{
    public partial class UCReportes : UserControl
    {
        private FormHome formHome;

        private UCRChoferes uCRChoferes;

        private UCREmpresas uCREmpresas;

        private UCRRutas uCRRutas;

        public UCReportes()
        {
            InitializeComponent();
        }

        public UCReportes(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
        }

        private void UCReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            togglePanels("choferes");
            btnChoferes.BackColor = Color.FromArgb(52, 60, 69);
        }
        private void togglePanels(string userControlPanel)
        {
            colorBtn();
            this.formHome.panelMain.Controls.Clear();
            switch (userControlPanel)
            {
                case "choferes":
                    this.uCRChoferes = new Vista.Reportes.UCRChoferes();
                    this.formHome.panelMain.Controls.Add(this.uCRChoferes);
                    this.uCRChoferes.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCRChoferes.Location = new System.Drawing.Point(0, 0);
                    this.uCRChoferes.Name = "uCRChoferes";
                    this.uCRChoferes.Size = new System.Drawing.Size(724, 485);
                    this.uCRChoferes.TabIndex = 1;
                    break;
                case "empresas":
                    this.uCREmpresas = new Vista.Reportes.UCREmpresas();
                    this.formHome.panelMain.Controls.Add(this.uCREmpresas);
                    this.uCREmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCREmpresas.Location = new System.Drawing.Point(0, 0);
                    this.uCREmpresas.Name = "uCREmpresas";
                    this.uCREmpresas.Size = new System.Drawing.Size(724, 485);
                    this.uCREmpresas.TabIndex = 1;
                    break;
                case "rutas":
                    this.uCRRutas = new Vista.Reportes.UCRRutas();
                    this.formHome.panelMain.Controls.Add(this.uCRRutas);
                    this.uCRRutas.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCRRutas.Location = new System.Drawing.Point(0, 0);
                    this.uCRRutas.Name = "uCLicencias";
                    this.uCRRutas.Size = new System.Drawing.Size(724, 485);
                    this.uCRRutas.TabIndex = 1;
                    break;
                default:
                    break;
            }
        }

        private void colorBtn()
        {
            btnEmpresa.BackColor = Color.FromArgb(39, 46, 54);
            btnChoferes.BackColor = Color.FromArgb(39, 46, 54);
            btnRutas.BackColor = Color.FromArgb(39, 46, 54);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            togglePanels("empresas");
            btnEmpresa.BackColor = Color.FromArgb(52, 60, 69);
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            togglePanels("rutas");
            btnRutas.BackColor = Color.FromArgb(52, 60, 69);
        }
    }
}
