using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Componentes;

namespace Vista.Crud
{
    public partial class FormImportarEmpresas : Form
    {
        public FormImportarEmpresas()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ExternalFiles.ImporExcel();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EmpresaController empresaController = new EmpresaController();
            DataTable empresas = (DataTable)dataGridView.DataSource;
            empresaController.insertEmpresa(empresas);
            this.Close();
        }
    }
}
