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
    public partial class UCMovimientos : UserControl
    {
        private FormHome formHome;

        public UCMovimientos()
        {
            InitializeComponent();
        }

        public UCMovimientos(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
        }
    }
}
