using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Crud;

namespace Vista.Navegacion
{
    public partial class UCCruds : UserControl
    {
        private FormHome formHome;

        private UCChoferes uCChoferes;
        private UCEmpresas uCEmpresas;
        private UCLicencias uCLicencias;
        private UCPapeletas uCPapeletas;
        private UCRutas uCRutas;
        private UCTipoEmpresa uCTipoEmpresa;
        private UCTipoVehiculo uCTipoVehiculo;
        private UCUsuarios uCUsuarios;
        private UCVehiculos uCVehiculos;

        public UCCruds()
        {
            InitializeComponent();
        }

        public UCCruds(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
        }

        private void UCCruds_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            togglePanels("empresas");
            btnEmpresas.BackColor = Color.FromArgb(52, 60, 69);
        }

        private void togglePanels(string userControlPanel)
        {
            colorBtn();
            this.formHome.panelMain.Controls.Clear();
            switch (userControlPanel)
            {
                case "choferes":
                    this.uCChoferes = new Vista.Crud.UCChoferes();
                    this.formHome.panelMain.Controls.Add(this.uCChoferes);
                    this.uCChoferes.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCChoferes.Location = new System.Drawing.Point(0, 0);
                    this.uCChoferes.Name = "uCChoferes";
                    this.uCChoferes.Size = new System.Drawing.Size(724, 485);
                    this.uCChoferes.TabIndex = 1;
                    break;
                case "empresas":
                    this.uCEmpresas = new Vista.Crud.UCEmpresas();
                    this.formHome.panelMain.Controls.Add(this.uCEmpresas);
                    this.uCEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCEmpresas.Location = new System.Drawing.Point(0, 0);
                    this.uCEmpresas.Name = "uCEmpresas";
                    this.uCEmpresas.Size = new System.Drawing.Size(724, 485);
                    this.uCEmpresas.TabIndex = 1;
                    break;
                case "licencias":
                    this.uCLicencias = new Vista.Crud.UCLicencias();
                    this.formHome.panelMain.Controls.Add(this.uCLicencias);
                    this.uCLicencias.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCLicencias.Location = new System.Drawing.Point(0, 0);
                    this.uCLicencias.Name = "uCLicencias";
                    this.uCLicencias.Size = new System.Drawing.Size(724, 485);
                    this.uCLicencias.TabIndex = 1;
                    break;
                case "papeletas":
                    this.uCPapeletas = new Vista.Crud.UCPapeletas();
                    this.formHome.panelMain.Controls.Add(this.uCPapeletas);
                    this.uCPapeletas.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCPapeletas.Location = new System.Drawing.Point(0, 0);
                    this.uCPapeletas.Name = "uCPapeletas";
                    this.uCPapeletas.Size = new System.Drawing.Size(724, 485);
                    this.uCPapeletas.TabIndex = 1;
                    break;
                case "rutas":
                    this.uCRutas = new Vista.Crud.UCRutas();
                    this.formHome.panelMain.Controls.Add(this.uCRutas);
                    this.uCRutas.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCRutas.Location = new System.Drawing.Point(0, 0);
                    this.uCRutas.Name = "uCRutas";
                    this.uCRutas.Size = new System.Drawing.Size(724, 485);
                    this.uCRutas.TabIndex = 1;
                    break;
                case "tipoempresa":
                    this.uCTipoEmpresa = new Vista.Crud.UCTipoEmpresa();
                    this.formHome.panelMain.Controls.Add(this.uCTipoEmpresa);
                    this.uCTipoEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCTipoEmpresa.Location = new System.Drawing.Point(0, 0);
                    this.uCTipoEmpresa.Name = "uCTipoEmpresa";
                    this.uCTipoEmpresa.Size = new System.Drawing.Size(724, 485);
                    this.uCTipoEmpresa.TabIndex = 1;
                    break;
                case "tipovehiculo":
                    this.uCTipoVehiculo = new Vista.Crud.UCTipoVehiculo();
                    this.formHome.panelMain.Controls.Add(this.uCTipoVehiculo);
                    this.uCTipoVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCTipoVehiculo.Location = new System.Drawing.Point(0, 0);
                    this.uCTipoVehiculo.Name = "uCTipoVehiculo";
                    this.uCTipoVehiculo.Size = new System.Drawing.Size(724, 485);
                    this.uCTipoVehiculo.TabIndex = 1;
                    break;
                case "usuarios":
                    this.uCUsuarios = new Vista.Crud.UCUsuarios();
                    this.formHome.panelMain.Controls.Add(this.uCUsuarios);
                    this.uCUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCUsuarios.Location = new System.Drawing.Point(0, 0);
                    this.uCUsuarios.Name = "uCUsuarios";
                    this.uCUsuarios.Size = new System.Drawing.Size(724, 485);
                    this.uCUsuarios.TabIndex = 1;
                    break;
                case "vehiculos":
                    this.uCVehiculos = new Vista.Crud.UCVehiculos();
                    this.formHome.panelMain.Controls.Add(this.uCVehiculos);
                    this.uCVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCVehiculos.Location = new System.Drawing.Point(0, 0);
                    this.uCVehiculos.Name = "uCVehiculos";
                    this.uCVehiculos.Size = new System.Drawing.Size(724, 485);
                    this.uCVehiculos.TabIndex = 1;
                    break;
                default:
                    break;
            }
        }

        private void colorBtn()
        {
            btnEmpresas.BackColor = Color.FromArgb(39, 46, 54);
            btnRutas.BackColor = Color.FromArgb(39, 46, 54);
            btnVehiuclos.BackColor = Color.FromArgb(39, 46, 54);
            btnChoferes.BackColor = Color.FromArgb(39, 46, 54);
            btnPapeletas.BackColor = Color.FromArgb(39, 46, 54);
            btnLicencias.BackColor = Color.FromArgb(39, 46, 54);
            btnTipoEmpresa.BackColor = Color.FromArgb(39, 46, 54);
            btnTipoVehiculo.BackColor = Color.FromArgb(39, 46, 54);
            btnUsuarios.BackColor = Color.FromArgb(39, 46, 54);
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            togglePanels("rutas");
            btnRutas.BackColor = Color.FromArgb(52, 60, 69);
        }

        private void btnVehiuclos_Click(object sender, EventArgs e)
        {
            togglePanels("vehiculos");
            btnVehiuclos.BackColor = Color.FromArgb(52, 60, 69);
        }

        private void btnChoferes_Click(object sender, EventArgs e)
        {
            togglePanels("choferes");
            btnChoferes.BackColor = Color.FromArgb(52, 60, 69);
        }

        private void btnPapeletas_Click(object sender, EventArgs e)
        {
            togglePanels("papeletas");
            btnPapeletas.BackColor = Color.FromArgb(52, 60, 69);
        }

        private void btnLicencias_Click(object sender, EventArgs e)
        {
            togglePanels("licencias");
            btnLicencias.BackColor = Color.FromArgb(52, 60, 69);
        }

        private void btnTipoEmpresa_Click(object sender, EventArgs e)
        {
            togglePanels("tipoempresa");
            btnTipoEmpresa.BackColor = Color.FromArgb(52, 60, 69);
        }

        private void btnTipoVehiculo_Click(object sender, EventArgs e)
        {
            togglePanels("tipovehiculo");
            btnTipoVehiculo.BackColor = Color.FromArgb(52, 60, 69);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            togglePanels("usuarios");
            btnUsuarios.BackColor = Color.FromArgb(52, 60, 69);
        }
    }
}
