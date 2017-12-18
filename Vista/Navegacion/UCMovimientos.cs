using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Movimiento;

namespace Vista.Navegacion
{
    public partial class UCMovimientos : UserControl
    {
        private FormHome formHome;

        private UCSancionar uCSancionar;

        private UCRegularizarSancion cRegularizarSancion;

        private UCAutorizar uCAutorizar;

        public UCMovimientos()
        {
            InitializeComponent();
        }

        public UCMovimientos(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
        }

        private void btnSancionar_Click(object sender, EventArgs e)
        {
            togglePanels("sancionar");
            btnSancionar.BackColor = Color.White;
        }
        private void togglePanels(string userControlPanel)
        {
            colorBtn();
            this.formHome.panelMain.Controls.Clear();
            switch (userControlPanel)
            {
                case "sancionar":
                    this.uCSancionar = new Vista.Movimiento.UCSancionar();
                    this.formHome.panelMain.Controls.Add(this.uCSancionar);
                    this.uCSancionar.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCSancionar.Location = new System.Drawing.Point(0, 0);
                    this.uCSancionar.Name = "uCSancionar";
                    this.uCSancionar.Size = new System.Drawing.Size(724, 485);
                    this.uCSancionar.TabIndex = 1;
                    break;
                case "autorizar":
                    this.uCAutorizar = new Vista.Movimiento.UCAutorizar();
                    this.formHome.panelMain.Controls.Add(this.uCAutorizar);
                    this.uCAutorizar.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCAutorizar.Location = new System.Drawing.Point(0, 0);
                    this.uCAutorizar.Name = "uCAutorizar";
                    this.uCAutorizar.Size = new System.Drawing.Size(724, 485);
                    this.uCAutorizar.TabIndex = 1;
                    break;
                case "regularizarsancion":
                    this.cRegularizarSancion = new Vista.Movimiento.UCRegularizarSancion();
                    this.formHome.panelMain.Controls.Add(this.cRegularizarSancion);
                    this.cRegularizarSancion.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.cRegularizarSancion.Location = new System.Drawing.Point(0, 0);
                    this.cRegularizarSancion.Name = "cRegularizarSancion";
                    this.cRegularizarSancion.Size = new System.Drawing.Size(724, 485);
                    this.cRegularizarSancion.TabIndex = 1;
                    break;
                default:
                    break;
            }
        }

        private void colorBtn()
        {
            btnAutorizar.BackColor = Color.FromArgb(242, 246, 252);
            btnSancionar.BackColor = Color.FromArgb(242, 246, 252);
            btnRegularizarSancion.BackColor = Color.FromArgb(242, 246, 252);
        }

        private void btnRegularizarSancion_Click(object sender, EventArgs e)
        {
            togglePanels("regularizarsancion");
            btnRegularizarSancion.BackColor = Color.White;
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            togglePanels("autorizar");
            btnAutorizar.BackColor = Color.White;
        }
    }
}
