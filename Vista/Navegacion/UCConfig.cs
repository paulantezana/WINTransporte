using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Configuracion;

namespace Vista.Navegacion
{
    public partial class UCConfig : UserControl
    {
        private FormHome formHome;

        private UCGeneral uCGeneral;

        private UCPerfil uCPerfil;

        private UCRoles uCRoles;

        private UCUsuarios uCUsuarios;

        public UCConfig()
        {
            InitializeComponent();
        }

        public UCConfig(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            togglePanels("Perfil");
            btnPerfil.BackColor = Color.White;
        }

        private void togglePanels(string userControlPanel)
        {
            colorBtn();
            this.formHome.panelMain.Controls.Clear();
            switch (userControlPanel)
            {
                case "general":
                    this.uCGeneral = new Vista.Configuracion.UCGeneral();
                    this.formHome.panelMain.Controls.Add(this.uCGeneral);
                    this.uCGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCGeneral.Location = new System.Drawing.Point(0, 0);
                    this.uCGeneral.Name = "uCGeneral";
                    this.uCGeneral.Size = new System.Drawing.Size(724, 485);
                    this.uCGeneral.TabIndex = 1;
                    break;
                case "perfil":
                    this.uCPerfil = new Vista.Configuracion.UCPerfil();
                    this.formHome.panelMain.Controls.Add(this.uCPerfil);
                    this.uCPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCPerfil.Location = new System.Drawing.Point(0, 0);
                    this.uCPerfil.Name = "uCEmpresas";
                    this.uCPerfil.Size = new System.Drawing.Size(724, 485);
                    this.uCPerfil.TabIndex = 1;
                    break;
                case "roles":
                    this.uCRoles = new Vista.Configuracion.UCRoles();
                    this.formHome.panelMain.Controls.Add(this.uCRoles);
                    this.uCRoles.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCRoles.Location = new System.Drawing.Point(0, 0);
                    this.uCRoles.Name = "uCRoles";
                    this.uCRoles.Size = new System.Drawing.Size(724, 485);
                    this.uCRoles.TabIndex = 1;
                    break;
                case "usuarios":
                    this.uCUsuarios = new Vista.Configuracion.UCUsuarios();
                    this.formHome.panelMain.Controls.Add(this.uCUsuarios);
                    this.uCUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCUsuarios.Location = new System.Drawing.Point(0, 0);
                    this.uCUsuarios.Name = "uCUsuarios";
                    this.uCUsuarios.Size = new System.Drawing.Size(724, 485);
                    this.uCUsuarios.TabIndex = 1;
                    break;
                default:
                    break;
            }
        }

        private void colorBtn()
        {
            btnGeneral.BackColor = Color.FromArgb(242, 246, 252);
            btnPerfil.BackColor = Color.FromArgb(242, 246, 252);
            btnRoles.BackColor = Color.FromArgb(242, 246, 252);
            btnUsuario.BackColor = Color.FromArgb(242, 246, 252);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            togglePanels("roles");
            btnRoles.BackColor = Color.White;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            togglePanels("usuarios");
            btnUsuario.BackColor = Color.White;
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            togglePanels("general");
            btnGeneral.BackColor = Color.White;
        }
    }
}
