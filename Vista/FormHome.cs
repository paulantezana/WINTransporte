using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Vista.Navegacion;
using Vista.Componentes;

namespace Vista
{
    public partial class FormHome : Form
    {
        private UCConfig uCConfig;

        private UCCruds uCCruds;

        private UCMovimientos uCMovimientos;

        private UCReportes uCReportes;

        private Usuario usuario;

        private FormLogin formLogin;

        public FormHome()
        {
            InitializeComponent();
        }

        public FormHome(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblUserName.Text = usuario.usuario;
            /*lblRool.Text = usuario.rool;*/
        }

        public FormHome(Usuario usuario, FormLogin formLogin) : this(usuario)
        {
            this.formLogin = formLogin;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics line = panelHeader.CreateGraphics();

            Brush brush = new SolidBrush(Color.FromArgb(211, 213, 217));
            Pen penRed = new Pen(brush, 1);

            line.DrawLine(penRed, 0, 44, 1630, 44);
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            togglePanels("cruds");
            btnCrud.BackColor = Color.FromArgb(212, 222, 240);
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            togglePanels("movimientos");
            btnMovimiento.BackColor = Color.FromArgb(212, 222, 240);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            togglePanels("reportes");
            btnReporte.BackColor = Color.FromArgb(212, 222, 240);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            togglePanels("config");
            btnConfig.BackColor = Color.FromArgb(212, 222, 240);
        }

        private void togglePanels(String userControlPanel)
        {
            colorBtn();
            this.panelAsideMain.Controls.Clear();
            switch (userControlPanel)
            {
                case "config":
                    this.uCConfig = new Vista.Navegacion.UCConfig(this);
                    this.panelAsideMain.Controls.Add(this.uCConfig);
                    this.uCConfig.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCConfig.Location = new System.Drawing.Point(0, 0);
                    this.uCConfig.Name = "uCConfig";
                    this.uCConfig.Size = new System.Drawing.Size(724, 485);
                    this.uCConfig.TabIndex = 1;
                    break;
                case "cruds":
                    this.uCCruds = new Vista.Navegacion.UCCruds(this);
                    this.panelAsideMain.Controls.Add(this.uCCruds);
                    this.uCCruds.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCCruds.Location = new System.Drawing.Point(0, 0);
                    this.uCCruds.Name = "uCCruds";
                    this.uCCruds.Size = new System.Drawing.Size(724, 485);
                    this.uCCruds.TabIndex = 1;
                    break;
                case "movimientos":
                    this.uCMovimientos = new Vista.Navegacion.UCMovimientos(this);
                    this.panelAsideMain.Controls.Add(this.uCMovimientos);
                    this.uCMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCMovimientos.Location = new System.Drawing.Point(0, 0);
                    this.uCMovimientos.Name = "uCConcepto";
                    this.uCMovimientos.Size = new System.Drawing.Size(724, 485);
                    this.uCMovimientos.TabIndex = 1;
                    break;
                case "reportes":
                    this.uCReportes = new Vista.Navegacion.UCReportes(this);
                    this.panelAsideMain.Controls.Add(this.uCReportes);
                    this.uCReportes.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCReportes.Location = new System.Drawing.Point(0, 0);
                    this.uCReportes.Name = "uCTipoDocumento";
                    this.uCReportes.Size = new System.Drawing.Size(724, 485);
                    this.uCReportes.TabIndex = 1;
                    break;
                default:
                    break;
            }
        }
        private void colorBtn()
        {
            btnCrud.BackColor = Color.FromArgb(15, 68, 160);
            btnMovimiento.BackColor = Color.FromArgb(15, 68, 160);
            btnReporte.BackColor = Color.FromArgb(15, 68, 160);
            btnConfig.BackColor = Color.FromArgb(15, 68, 160);
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formLogin.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawShape drawShape = new DrawShape();
            drawShape.bottomLine(panel1);
        }
    }
}
