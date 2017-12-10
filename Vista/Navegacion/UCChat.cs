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
    public partial class UCChat : UserControl
    {
        private FormHome formHome;

        public UCChat()
        {
            InitializeComponent();
        }

        public UCChat(FormHome formHome)
        {
            InitializeComponent();
            this.formHome = formHome;
        }
    }
}
