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
    public partial class UCConsultas : UserControl
    {
        private FormHome formHome;

        public UCConsultas()
        {
            InitializeComponent();
        }

        public UCConsultas(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
        }
    }
}
