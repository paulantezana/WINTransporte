using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            /*
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.FileName = "Archivo nuevo";
            openFile.Filter = 
            */
        }
    }
}
