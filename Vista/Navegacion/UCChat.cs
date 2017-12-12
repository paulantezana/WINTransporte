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
    public partial class UCChat : UserControl
    {
        private FormHome formHome;

        private UCPerfil uCPerfil;

        public UCChat()
        {
            InitializeComponent();
        }

        public UCChat(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            togglePanels("perfil");
            btnPerfil.BackColor = Color.FromArgb(52, 60, 69);
        }
        private void togglePanels(string userControlPanel)
        {
            colorBtn();
            this.formHome.panelMain.Controls.Clear();
            switch (userControlPanel)
            {
                case "perfil":
                    this.uCPerfil = new Vista.Configuracion.UCPerfil();
                    this.formHome.panelMain.Controls.Add(this.uCPerfil);
                    this.uCPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.uCPerfil.Location = new System.Drawing.Point(0, 0);
                    this.uCPerfil.Name = "uCChoferes";
                    this.uCPerfil.Size = new System.Drawing.Size(724, 485);
                    this.uCPerfil.TabIndex = 1;
                    break;
                default:
                    break;
            }
        }

        private void colorBtn()
        {
            btnPerfil.BackColor = Color.FromArgb(39, 46, 54);
        }
    }
}
