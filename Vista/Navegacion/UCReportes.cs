using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Navegacion
{
    public partial class UCReportes : UserControl
    {
        private FormHome formHome;

        public UCReportes()
        {
            InitializeComponent();
        }

        public UCReportes(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
        }
    }
}
